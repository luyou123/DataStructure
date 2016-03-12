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
	long long z;
	data(){}
}*a;
int n, m, xa, ya, xb, yb, tot, tot2, toty, tot3, lz, rz, splitnode, splitnodey, ans;
long long za, zb;
struct rec
{
	int l, r, yl, yr; //y region tree
	int lc, rc, fa, root;
}*tree;
struct rec2
{
	int v, id; //a[id]
	int nxtboe[2]; // smallest >=
	int nxtsoe[2]; // largest <=
}*tree2;
struct rec3
{
	long long v;
	int id;
	int nxtboe[2];
	int nxtsoe[2];
}*tree3;
struct recy
{
	int l, r, zl, zr;
	int lc, rc, fa;
}*treey;
struct dataxy
{
	int v, id;
	dataxy(){}
}*tx;
struct dataxyI64D
{
	long long v;
	int id;
	dataxyI64D(){}
}*tz;
bool cmpxz(dataxy t1, dataxy t2)
{
	return t1.v < t2.v;
}
bool cmpxzI64D(dataxyI64D t1, dataxyI64D t2)
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
int findbiggerorequalzI64D(int ll, int rr, long long v)
{
	int ret = -1;
	while (ll <= rr)
	{
		int mid = (ll + rr) / 2;
		if (tree3[mid].v >= v) { ret = mid; rr = mid - 1; }
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
int findsmallerorequalz(int ll, int rr, int v)
{
	int ret = -1;
	while (ll <= rr)
	{
		int mid = (ll + rr) / 2;
		if (tree3[mid].v <= v) { ret = mid; ll = mid + 1; }
		else rr = mid - 1;
	}
	return ret;
}
int findsmallerorequalzI64D(int ll, int rr, long long v)
{
	int ret = -1;
	while (ll <= rr)
	{
		int mid = (ll + rr) / 2;
		if (tree3[mid].v <= v) { ret = mid; ll = mid + 1; }
		else rr = mid - 1;
	}
	return ret;
}
void buildsegtreey(int f, int t, int x, int from, int last) // build y region tree (from..from+R-L)
{
	treey[x].l = f; treey[x].r = t; treey[x].fa = last;
	if (f == t)
	{
		tree3[++tot3].id = tree2[from + f - 1].id;
		tree3[tot3].v = a[tree3[tot3].id].z;
		treey[x].zl = treey[x].zr = tot3;
		return;
	}
	treey[x].lc = ++toty;
	treey[x].rc = ++toty;
	buildsegtreey(f, (f + t) / 2, treey[x].lc, from, x);
	buildsegtreey((f + t) / 2 + 1, t, treey[x].rc, from, x);
	int l[2], r[2];
	l[0] = treey[treey[x].lc].zl, r[0] = treey[treey[x].lc].zr;
	l[1] = treey[treey[x].rc].zl, r[1] = treey[treey[x].rc].zr;
	int p = l[0], q = l[1], begin = tot3 + 1;
	while (p <= r[0] && q <= r[1])
	{
		if (tree3[p].v < tree3[q].v)
		{
			while (p <= r[0] && tree3[p].v < tree3[q].v) { tree3[++tot3].v = tree3[p].v; tree3[tot3].id = tree3[p].id; p++; }
		}
		else
		{
			while (q <= r[1] && tree3[q].v <= tree3[p].v) { tree3[++tot3].v = tree3[q].v; tree3[tot3].id = tree3[q].id; q++; }
		}
	}
	while (p <= r[0]) { tree3[++tot3].v = tree3[p].v; tree3[tot3].id = tree3[p].id; p++; }
	while (q <= r[1]) { tree3[++tot3].v = tree3[q].v; tree3[tot3].id = tree3[q].id; q++; }
	treey[x].zl = begin; treey[x].zr = tot3;
	for (int opt = 0; opt <= 1; opt++) //minimum >=
	{
		int res = findbiggerorequalzI64D(l[opt], r[opt], tree3[treey[x].zl].v);
		//find the minimum res(res>=l[opt] && res<=r[opt] such that tree3[res].v first satisfy >=tree3[treey[x].zl].v
		tree3[treey[x].zl].nxtboe[opt] = res;
		p = res;
		int i = treey[x].zl + 1;
		while (i <= treey[x].zr && p <= r[opt])
		{
			while (p <= r[opt] && tree3[i].v > tree3[p].v) p++; //first >=
			if (p > r[opt]) break;
			while (i <= treey[x].zr && tree3[i].v <= tree3[p].v)  { tree3[i].nxtboe[opt] = p; i++; }
		}
		if (i <= treey[x].zr && p > r[opt]) while (i <= treey[x].zr) { tree3[i].nxtboe[opt] = -1; i++; }
	}

	for (int opt = 0; opt <= 1; opt++) //maximum <=
	{
		int res = findsmallerorequalzI64D(l[opt], r[opt], tree3[treey[x].zr].v);
		tree3[treey[x].zr].nxtsoe[opt] = res;
		p = res;
		int i = treey[x].zr - 1;
		while (i >= treey[x].zl && p >= l[opt])
		{
			while (p >= l[opt] && tree3[i].v < tree3[p].v) p--;
			if (p < l[opt]) break;
			while (i >= treey[x].zl && tree3[i].v >= tree3[p].v)  { tree3[i].nxtsoe[opt] = p; i--; }
		}
		if (i >= treey[x].zl && p < l[opt]) while (i >= treey[x].zl) { tree3[i].nxtsoe[opt] = -1; i--; }
	}
}
void buildsegtree(int f, int t, int x, int last)
{
	tree[x].l = f; tree[x].r = t; tree[x].fa = last;
	if (f == t)
	{
		tree2[++tot2].id = tx[f].id; // x sorted the f-th original in the a array the tx[f].id-th
		tree2[tot2].v = a[tree2[tot2].id].y; // tree2[tot2].id (belong to which element in the original a array)		
		tree[x].yl = tree[x].yr = tot2;
		tree[x].root = ++toty;
		buildsegtreey(1, 1, toty, tree[x].yl, 0);
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
			while (p <= r[0] && tree2[p].v < tree2[q].v) { tree2[++tot2].v = tree2[p].v; tree2[tot2].id = tree2[p].id; p++; }
		}
		else
		{
			while (q <= r[1] && tree2[q].v <= tree2[p].v) { tree2[++tot2].v = tree2[q].v; tree2[tot2].id = tree2[q].id; q++; }
		}
	}
	while (p <= r[0]) { tree2[++tot2].v = tree2[p].v; tree2[tot2].id = tree2[p].id; p++; }
	while (q <= r[1]) { tree2[++tot2].v = tree2[q].v; tree2[tot2].id = tree2[q].id; q++; }
	tree[x].yl = begin; tree[x].yr = tot2; tree[x].root = ++toty;
	buildsegtreey(1, tree[x].yr - tree[x].yl + 1, toty, tree[x].yl, 0); //tree[x].yl-1 +1
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
	tz = (dataxyI64D *)malloc(sizeof(dataxyI64D)*(n + 10));
	double t = ceil(log((double)n) / log(2.0) + 0.5);
	int nodelog = ((int)t + 2)*(n + 1);
	tree = (rec *)malloc(sizeof(rec)* nodelog);
	tree2 = (rec2 *)malloc(sizeof(rec2)* 4 * nodelog);
	t = t*t;
	int nodelogpower = ((int)t + 2)*(n + 1);
	treey = (recy *)malloc(sizeof(recy)* 8 * nodelog);
	tree3 = (rec3 *)malloc(sizeof(rec3)* 2 * nodelogpower);
	for (int i = 1; i <= n; i++) { fscanf(fin,"%d %d %I64d", &a[i].x, &a[i].y, &a[i].z); tx[i].v = a[i].x; tx[i].id = i; tz[i].v = a[i].z; tz[i].id = i; }
	sort(tx, tx + n + 1, cmpxz);
	sort(tz, tz + n + 1, cmpxzI64D);
	tot = 1;
	tot2 = 0;
	toty = 0;
	tot3 = 0;
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
int findxb(int x)
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
int findza(long long z)
{
	int l = 1, r = n, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (z <= tz[mid].v) { ret = mid; r = mid - 1; }
		else l = mid + 1;
	}
	return ret;
}
int findzb(long long z)
{
	int l = 1, r = n, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (z >= tz[mid].v) { ret = mid; l = mid + 1; }
		else r = mid - 1;
	}
	return ret;
}
void findsplity(int f, int t, int x)
{
	if (f <= treey[x].l && treey[x].r <= t) { splitnodey = x; return; }
	if (t <= treey[treey[x].lc].r) { findsplity(f, t, treey[x].lc); return; }
	if (f >= treey[treey[x].rc].l) { findsplity(f, t, treey[x].rc); return; }
	splitnodey = x;
}
int dfsy(int f, int t, int x, int boe, int soe)
{
	if (boe == -1 || soe == -1 || boe > soe) return 0;
	if (f <= treey[x].l && treey[x].r <= t)
	{
		return soe - boe + 1;
	}
	int ret = 0;
	if (f <= treey[treey[x].lc].r)
	{
		ret = dfsy(f, t, treey[x].lc, tree3[boe].nxtboe[0], tree3[soe].nxtsoe[0]);
	}
	if (t >= treey[treey[x].rc].l)
	{
		ret += dfsy(f, t, treey[x].rc, tree3[boe].nxtboe[1], tree3[soe].nxtsoe[1]);
	}
	return ret;
}
int calcy(int f, int t, int x)
{
	int boe = findbiggerorequalzI64D(treey[x].zl, treey[x].zr, za);
	int soe = findsmallerorequalzI64D(treey[x].zl, treey[x].zr, zb);
	return dfsy(f, t, x, boe, soe);
}
int findy(int rooty, int ly, int ry)
{
	splitnodey = 0;
	findsplity(ly, ry, rooty);
	return calcy(ly, ry, splitnodey);
}
void findsplit(int f, int t, int x)
{
	if (f <= tree[x].l && tree[x].r <= t) { splitnode = x; return; }
	if (t <= tree[tree[x].lc].r) { findsplit(f, t, tree[x].lc); return; }
	if (f >= tree[tree[x].rc].l) { findsplit(f, t, tree[x].rc); return; }
	splitnode = x;
}
int dfs(int f, int t, int x, int boe, int soe)
{
	if (boe == -1 || soe == -1 || boe > soe) return 0;
	if (f <= tree[x].l && tree[x].r <= t)
	{
		//return soe - boe + 1;
		return findy(tree[x].root, boe - tree[x].yl + 1, soe - tree[x].yl + 1);
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
	int boe = findbiggerorequal(tree[x].yl, tree[x].yr, ya);
	int soe = findsmallerorequal(tree[x].yl, tree[x].yr, yb);
	return dfs(f, t, x, boe, soe);
}
int findx(int lx, int rx)
{
	splitnode = 0;
	findsplit(lx, rx, 1);
	return calc(lx, rx, splitnode);
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
		fscanf(fin,"%d", &m);
		FILE *fout = fopen("2.out", "w");
		for (int i = 1; i <= m; i++)
		{
			fscanf(fin,"%d %d %I64d %d %d %I64d", &xa, &ya, &za, &xb, &yb, &zb);
			int l1, r1;
			l1 = findxa(xa);
			r1 = findxb(xb);
			if (l1 > r1 || l1 == -1 || r1 == -1) { fprintf(fout,"0\n"); continue; }
			if (ya > yb) { fprintf(fout,"0\n"); continue; }
			lz = findza(za);
			rz = findzb(zb);
			ans = 0;
			ans = findx(l1, r1);
			fprintf(fout,"%d\n", ans);
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
