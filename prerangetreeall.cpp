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
#define INF 0x7FFFFFFF
#define maxx 18508
using namespace std;
int flag[maxx],maxxx,maxyy,minxx,minyy;
struct data
{
	int x, y;
	data(){}
}*a[maxx];
int n[maxx], m, xa, xb, xc, xd, tot, tot2, ly, ry, splitnode, ans,nowid;
struct rec
{
	int l, r, yl, yr; //y region tree
	int lc, rc, fa;
}*tree[maxx];
struct rec2
{
	int v;
	int nxtboe[2]; // smallest >=
	int nxtsoe[2]; // largest <=
}*tree2[maxx];
struct dataxy
{
	int v, id;
	dataxy(){}
}*tx[maxx], *ty[maxx];
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
		if (tree2[nowid][mid].v >= v) { ret = mid; rr = mid - 1; }
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
		if (tree2[nowid][mid].v <= v) { ret = mid; ll = mid + 1; }
		else rr = mid - 1;
	}
	return ret;
}
void buildsegtree(int f, int t, int x, int last)
{
	tree[nowid][x].l = f; tree[nowid][x].r = t; tree[nowid][x].fa = last;
	if (f == t)
	{
		tree2[nowid][++tot2].v = a[nowid][tx[nowid][f].id].y;
		tree[nowid][x].yl = tree[nowid][x].yr = tot2;
		return;
	}
	tree[nowid][x].lc = ++tot;
	tree[nowid][x].rc = ++tot;
	buildsegtree(f, (f + t) / 2, tree[nowid][x].lc, x);
	buildsegtree((f + t) / 2 + 1, t, tree[nowid][x].rc, x);
	int l[2], r[2];
	l[0] = tree[nowid][tree[nowid][x].lc].yl, r[0] = tree[nowid][tree[nowid][x].lc].yr;
	l[1] = tree[nowid][tree[nowid][x].rc].yl, r[1] = tree[nowid][tree[nowid][x].rc].yr;
	int p = l[0], q = l[1], begin = tot2 + 1;
	while (p <= r[0] && q <= r[1])
	{
		if (tree2[nowid][p].v < tree2[nowid][q].v)
		{
			while (p <= r[0] && tree2[nowid][p].v < tree2[nowid][q].v) { tree2[nowid][++tot2].v = tree2[nowid][p].v; p++; }
		}
		else
		{
			while (q <= r[1] && tree2[nowid][q].v <= tree2[nowid][p].v) { tree2[nowid][++tot2].v = tree2[nowid][q].v; q++; }
		}
	}
	while (p <= r[0]) { tree2[nowid][++tot2].v = tree2[nowid][p].v; p++; }
	while (q <= r[1]) { tree2[nowid][++tot2].v = tree2[nowid][q].v; q++; }
	tree[nowid][x].yl = begin; tree[nowid][x].yr = tot2;
	for (int opt = 0; opt <= 1; opt++)
	{
		int res = findbiggerorequal(l[opt], r[opt], tree2[nowid][tree[nowid][x].yl].v);
		tree2[nowid][tree[nowid][x].yl].nxtboe[opt] = res;
		p = res;
		int i = tree[nowid][x].yl + 1;
		while (i <= tree[nowid][x].yr && p <= r[opt])
		{
			while (p <= r[opt] && tree2[nowid][i].v > tree2[nowid][p].v) p++;
			if (p > r[opt]) break;
			while (i <= tree[nowid][x].yr && tree2[nowid][i].v <= tree2[nowid][p].v)  { tree2[nowid][i].nxtboe[opt] = p; i++; }
		}
		if (i <= tree[nowid][x].yr && p > r[opt]) while (i <= tree[nowid][x].yr) { tree2[nowid][i].nxtboe[opt] = -1; i++; }
	}

	for (int opt = 0; opt <= 1; opt++)
	{
		int res = findsmallerorequal(l[opt], r[opt], tree2[nowid][tree[nowid][x].yr].v);
		tree2[nowid][tree[nowid][x].yr].nxtsoe[opt] = res;
		p = res;
		int i = tree[nowid][x].yr - 1;
		while (i >= tree[nowid][x].yl && p >= l[opt])
		{
			while (p >= l[opt] && tree2[nowid][i].v < tree2[nowid][p].v) p--;
			if (p < l[opt]) break;
			while (i >= tree[nowid][x].yl && tree2[nowid][i].v >= tree2[nowid][p].v)  { tree2[nowid][i].nxtsoe[opt] = p; i--; }
		}
		if (i >= tree[nowid][x].yl && p < l[opt]) while (i >= tree[nowid][x].yl) { tree2[nowid][i].nxtsoe[opt] = -1; i--; }
	}
}
void init(FILE *fin)
{
	fscanf(fin, "%d", &n[nowid]);
	if (n [nowid]== 0) { flag[nowid] = 0;  return; }
	a[nowid]= (data *)malloc(sizeof(data)*(n[nowid] + 2));
	tx[nowid] = (dataxy *)malloc(sizeof(dataxy)*(n[nowid] + 2));
	ty[nowid] = (dataxy *)malloc(sizeof(dataxy)*(n[nowid]+ 2));
	tree[nowid] = (rec *)malloc(sizeof(rec)* n[nowid] * 4);
	double t = ceil(log((double)n[nowid]) / log(2.0));
	int node = ((int)t + 2)*(n[nowid] + 1);
	tree2 [nowid]= (rec2 *)malloc(sizeof(rec2)*node);

	for (int i = 1; i <= n[nowid]; i++) 
	{
		fscanf(fin,"%d %d", &a[nowid][i].x, &a[nowid][i].y); 
		if (a[nowid][i].x < 396000000 || a[nowid][i].x >= 408000000 || a[nowid][i].y <= 115800000 || a[nowid][i].y >= 117000000) { flag[nowid] = 0; return;  }
		minxx = min(minxx, a[nowid][i].x);
		maxxx = max(maxxx, a[nowid][i].x);
		minyy = min(minyy, a[nowid][i].y);
		maxyy = max(maxyy, a[nowid][i].y);
		tx[nowid][i].v = a[nowid][i].x; tx[nowid][i].id = i; ty[nowid][i].v = a[nowid][i].y; ty[nowid][i].id = i; 
	}
	sort(tx[nowid], tx[nowid] + n[nowid] + 1, cmpxy);
	sort(ty[nowid], ty[nowid] + n[nowid] + 1, cmpxy);
	tot = 1;
	tot2 = 0;
	buildsegtree(1, n[nowid], 1, 0);	
}
int findxa(int x)
{
	int l = 1, r = n[nowid], ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (x <= tx[nowid][mid].v) { ret = mid; r = mid - 1; }
		else l = mid + 1;
	}
	return ret;
}
int findxc(int x)
{
	int l = 1, r = n[nowid], ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (x >= tx[nowid][mid].v) { ret = mid; l = mid + 1; }
		else r = mid - 1;
	}
	return ret;
}
int findyb(int y)
{
	int l = 1, r = n[nowid], ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (y <= ty[nowid][mid].v) { ret = mid; r = mid - 1; }
		else l = mid + 1;
	}
	return ret;
}
int findyd(int y)
{
	int l = 1, r = n[nowid], ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (y >= ty[nowid][mid].v) { ret = mid; l = mid + 1; }
		else r = mid - 1;
	}
	return ret;
}
void findsplit(int f, int t, int x)
{
	if (f <= tree[nowid][x].l && tree[nowid][x].r <= t) { splitnode = x; return; }
	if (t <= tree[nowid][tree[nowid][x].lc].r) { findsplit(f, t, tree[nowid][x].lc); return; }
	if (f >= tree[nowid][tree[nowid][x].rc].l) { findsplit(f, t, tree[nowid][x].rc); return; }
	splitnode = x;
}
int dfs(int f, int t, int x, int boe, int soe)
{

	if (boe == -1 || soe == -1 || boe > soe) return 0;
	if (f <= tree[nowid][x].l && tree[nowid][x].r <= t)
	{
		return soe - boe + 1;
	}
	int ret = 0;
	if (f <= tree[nowid][tree[nowid][x].lc].r)
	{
		ret = dfs(f, t, tree[nowid][x].lc, tree2[nowid][boe].nxtboe[0], tree2[nowid][soe].nxtsoe[0]);
	}
	if (ret) return ret;
	if (t >= tree[nowid][tree[nowid][x].rc].l)
	{
		ret += dfs(f, t, tree[nowid][x].rc, tree2[nowid][boe].nxtboe[1], tree2[nowid][soe].nxtsoe[1]);
	}
	return ret;
}
int calc(int f, int t, int x)
{
	int boe = findbiggerorequal(tree[nowid][x].yl, tree[nowid][x].yr, ty[nowid][ly].v);
	int soe = findsmallerorequal(tree[nowid][x].yl, tree[nowid][x].yr, ty[nowid][ry].v);
	return dfs(f, t, x, boe, soe);
}
int main()
{
	clock_t start, finish;
	start = clock();
	maxxx = maxyy = 0;
	minxx = minyy = INF;
	for (int i = 1; i <= maxx-1; i++)
	{
		nowid = i;
		char filename[11];		
		_itoa(i, filename, 10);
		strcat(filename, ".in");
		FILE *fin = fopen(filename, "r");		
		flag[i] = 1;
		init(fin);
		fclose(fin);	
		cout << i<<"\n";
	}	
	//cout << minxx << " " << maxxx << " " << minyy << " " << maxyy << "\n";
	finish = clock();
	double duration = (double)(finish - start) / CLOCKS_PER_SEC;
	cout << "Initialization" << " takes " << duration << " s\n";
	cout << "Run the program?(Y/N)\n";
	char ch = getchar();
	while (ch == 'y' || ch == 'Y')
	{
		start = clock();
		FILE *fin2 = fopen("query.in", "r");
		FILE *fout = fopen("2.out", "w");
		fscanf(fin2, "%d", &m);
		for (int i = 1; i <= m; i++)
		{
			fscanf(fin2, "%d %d %d %d", &xa, &xb, &xc, &xd);
			int cnt = 0;
			for (int j = 1; j <= maxx - 1; j++)
			{
				nowid = j;
				if (!flag[j]) continue;
				int l1, r1;
				l1 = findxa(xa);
				r1 = findxc(xc);
				if (l1 > r1 || l1 == -1 || r1 == -1) continue;
				ly = findyb(xb);
				ry = findyd(xd);
				if (ly > ry || ly == -1 || ry == -1) continue;
				findsplit(l1, r1, 1);
				ans = calc(l1, r1, splitnode);
				if (ans) cnt++;				
				/*bool flag1 = 0;
				for (int k = 1; k <= n[j]; k++)
				{
					if (a[j][k].x >= xa && a[j][k].x <= xc && a[j][k].y >= xb && a[j][k].y <= xd)
					{
						flag1 = 1;
						break;
					}
				}
				if (flag1) cnt++;*/
			}
			fprintf(fout, "%d\n", cnt);			
		}
		fclose(fin2);
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

