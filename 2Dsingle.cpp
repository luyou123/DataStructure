// prerangetree.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include<cstdio>
#include<cstdlib>
#include<cstring>
#include<algorithm>
#include<vector>
#include<set>
#include<iostream>
#include<cmath>
#include<ctime>
using namespace std;
struct data
{
	int x, y;
	data(){}
}*a;
int n, m, xa, xb, xc, xd, tot, tot2, ly, ry, splitnode, ans, tt;
struct rec
{
	int l, r, yl, yr; //y region tree
	int lc, rc, fa;
}*tree;
struct rec2
{
	int v;
	int nxtboe[2]; // smallest >=
	int nxtsoe[2]; // largest <=
}*tree2;
struct dataxy
{
	int v, id;
	dataxy(){}
}*tx, *ty;
bool cmpxy(dataxy t1, dataxy t2)
{
	return t1.v < t2.v;
}
int findbiggerorequal(int ll, int rr, int v)
{
	int ret = -1;
	while (ll <= rr)
	{
		int mid = (ll + rr) / 2;
		if (tree2[mid].v >= v) { ret = mid; rr = mid - 1; }
		else ll = mid + 1;
	}
	return ret;
}
int findsmallerorequal(int ll, int rr, int v)
{
	int ret = -1;
	while (ll <= rr)
	{
		int mid = (ll + rr) / 2;
		if (tree2[mid].v <= v) { ret = mid; ll = mid + 1; }
		else rr = mid - 1;
	}
	return ret;
}
void buildsegtree(int f, int t, int x, int last)
{
	tree[x].l = f; tree[x].r = t; tree[x].fa = last;
	if (f == t)
	{
		tree2[++tot2].v = a[tx[f].id].y;
		tree[x].yl = tree[x].yr = tot2;
		return;
	}
	tree[x].lc = ++tot;
	tree[x].rc = ++tot;
	buildsegtree(f, (f + t) / 2, tree[x].lc, x);
	buildsegtree((f + t) / 2 + 1, t, tree[x].rc, x);
	int l[2], r[2];
	l[0] = tree[tree[x].lc].yl, r[0] = tree[tree[x].lc].yr;
	l[1] = tree[tree[x].rc].yl, r[1] = tree[tree[x].rc].yr;
	int p = l[0], q = l[1], begin = tot2 + 1;
	while (p <= r[0] && q <= r[1])
	{
		if (tree2[p].v < tree2[q].v)
		{
			while (p <= r[0] && tree2[p].v < tree2[q].v) { tree2[++tot2].v = tree2[p].v; p++; }
		}
		else
		{
			while (q <= r[1] && tree2[q].v <= tree2[p].v) { tree2[++tot2].v = tree2[q].v; q++; }
		}
	}
	while (p <= r[0]) { tree2[++tot2].v = tree2[p].v; p++; }
	while (q <= r[1]) { tree2[++tot2].v = tree2[q].v; q++; }
	tree[x].yl = begin; tree[x].yr = tot2;
	for (int opt = 0; opt <= 1; opt++)
	{
		int res = findbiggerorequal(l[opt], r[opt], tree2[tree[x].yl].v);
		tree2[tree[x].yl].nxtboe[opt] = res;
		p = res;
		int i = tree[x].yl + 1;
		while (i <= tree[x].yr && p <= r[opt])
		{
			while (p <= r[opt] && tree2[i].v > tree2[p].v) p++;
			if (p > r[opt]) break;
			while (i <= tree[x].yr && tree2[i].v <= tree2[p].v)  { tree2[i].nxtboe[opt] = p; i++; }
		}
		if (i <= tree[x].yr && p > r[opt]) while (i <= tree[x].yr) { tree2[i].nxtboe[opt] = -1; i++; }
	}

	for (int opt = 0; opt <= 1; opt++)
	{
		int res = findsmallerorequal(l[opt], r[opt], tree2[tree[x].yr].v);
		tree2[tree[x].yr].nxtsoe[opt] = res;
		p = res;
		int i = tree[x].yr - 1;
		while (i >= tree[x].yl && p >= l[opt])
		{
			while (p >= l[opt] && tree2[i].v < tree2[p].v) p--;
			if (p < l[opt]) break;
			while (i >= tree[x].yl && tree2[i].v >= tree2[p].v)  { tree2[i].nxtsoe[opt] = p; i--; }
		}
		if (i >= tree[x].yl && p < l[opt]) while (i >= tree[x].yl) { tree2[i].nxtsoe[opt] = -1; i--; }
	}
}
void init(FILE *fin)
{
	fscanf(fin,"%d", &n);
	a = (data *)malloc(sizeof(data)*(n + 10));
	tx = (dataxy *)malloc(sizeof(dataxy)*(n + 10));
	ty = (dataxy *)malloc(sizeof(dataxy)*(n + 10));
	tree = (rec *)malloc(sizeof(rec)* n * 4);
	double t = ceil(log((double)n) / log(2.0));
	int node = ((int)t + 2)*(n + 1);
	tree2 = (rec2 *)malloc(sizeof(rec2)*node);
	for (int i = 1; i <= n; i++) { fscanf(fin,"%d %d", &a[i].x, &a[i].y); tx[i].v = a[i].x; tx[i].id = i; ty[i].v = a[i].y; ty[i].id = i; }
	sort(tx, tx + n + 1, cmpxy);
	sort(ty, ty + n + 1, cmpxy);
	tot = 1;
	tot2 = 0;
	buildsegtree(1, n, 1, 0);
}
int findxa(int x)
{
	int l = 1, r = n, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (x <= tx[mid].v) { ret = mid; r = mid - 1; }
		else l = mid + 1;
	}
	return ret;
}
int findxc(int x)
{
	int l = 1, r = n, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (x >= tx[mid].v) { ret = mid; l = mid + 1; }
		else r = mid - 1;
	}
	return ret;
}
int findyb(int y)
{
	int l = 1, r = n, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (y <= ty[mid].v) { ret = mid; r = mid - 1; }
		else l = mid + 1;
	}
	return ret;
}
int findyd(int y)
{
	int l = 1, r = n, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (y >= ty[mid].v) { ret = mid; l = mid + 1; }
		else r = mid - 1;
	}
	return ret;
}
void findsplit(int f, int t, int x)
{
	tt++;
	if (f <= tree[x].l && tree[x].r <= t) { splitnode = x; return; }
	if (t <= tree[tree[x].lc].r) { findsplit(f, t, tree[x].lc); return; }
	if (f >= tree[tree[x].rc].l) { findsplit(f, t, tree[x].rc); return; }
	splitnode = x;
}
int dfs(int f, int t, int x, int boe, int soe)
{
	tt++;
	if (boe == -1 || soe == -1 || boe > soe) return 0;
	if (f <= tree[x].l && tree[x].r <= t)
	{
		return soe - boe + 1;
	}
	int ret = 0;
	if (f <= tree[tree[x].lc].r)
	{
		ret = dfs(f, t, tree[x].lc, tree2[boe].nxtboe[0], tree2[soe].nxtsoe[0]);
	}
	if (t >= tree[tree[x].rc].l)
	{
		ret += dfs(f, t, tree[x].rc, tree2[boe].nxtboe[1], tree2[soe].nxtsoe[1]);
	}
	return ret;
}
int calc(int f, int t, int x)
{
	int boe = findbiggerorequal(tree[x].yl, tree[x].yr, ty[ly].v);
	int soe = findsmallerorequal(tree[x].yl, tree[x].yr, ty[ry].v);
	return dfs(f, t, x, boe, soe);
}
int main()
{
	clock_t start, finish;
	double duration;
	cout << "Run the program?(Y/N)\n";
	char ch = getchar();
	FILE *fin = fopen("1.txt", "r");
	init(fin);
	fclose(fin);
	while (ch == 'y' || ch == 'Y')
	{
		start = clock();		
		fin = fopen("query.in", "r");
		fscanf(fin, "%d", &m);
		FILE *fout = fopen("2.out", "w");
		for (int i = 1; i <= m; i++)
		{
			fscanf(fin, "%d %d %d %d", &xa, &xb, &xc, &xd);
			int l1, r1;
			l1 = findxa(xa);
			r1 = findxc(xc);
			if (l1 > r1 || l1 == -1 || r1 == -1) { fprintf(fout, "0\n"); continue; }
			ly = findyb(xb);
			ry = findyd(xd);
			if (ly > ry || ly == -1 || ry == -1) { fprintf(fout, "0\n"); continue; }
			findsplit(l1, r1, 1);
			tt = 0;
			ans = calc(l1, r1, splitnode);
			fprintf(fout, "%d\n", ans);
		}
		fclose(fin);
		fclose(fout);
		finish = clock();
		duration = (double)(finish - start) / CLOCKS_PER_SEC;
		cout << "Time: " << duration << " s\n";
		cout << "Run the program?(Y/N)\n";
		ch = getchar();
		ch = getchar();
	}
	return 0;
}
