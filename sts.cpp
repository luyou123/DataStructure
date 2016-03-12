#include"stdafx.h"
#include<cstdio>
#include<cstdlib>
#include<cstring>
#include<algorithm>
#include<vector>
#include<set>
#include<iostream>
#include<cmath>
#define RED 0
#define BLACK 1
#define nil 0
using namespace std;
struct data
{
	int x, y;
	data(int a, int b) :x(a), y(b){}
	data(){}
	friend bool operator < (data t1, data t2)
	{
		return (t1.y<t2.y);
	}
}*a;
struct RBTree
{
	int lc, rc, fa, col, size,key;
}*rbt;
int root,tot;
void initrbtree()
{
	rbt[nil].lc = rbt[nil].rc = nil;
	rbt[nil].fa = nil;
	rbt[nil].col = BLACK;
	rbt[nil].size = 0;
}
void update(int x)
{
	if (x == nil) return;
	rbt[x].size = rbt[rbt[x].lc].size + rbt[rbt[x].rc].size + 1;
}
void LR(int x,int &root)
{
	int y = rbt[x].rc;
	rbt[x].rc = rbt[y].lc;
	if (rbt[y].lc!= nil) rbt[rbt[y].lc].fa = x;
	rbt[y].fa = rbt[x].fa;
	if (rbt[x].fa == nil) root = y; //no one node points to y
	else if (x == rbt[rbt[x].fa].lc) rbt[rbt[x].fa].lc = y;
	else rbt[rbt[x].fa].rc = y;
	rbt[x].fa = y;
	rbt[y].lc = x;
	update(x);
	update(y);
}
void RR(int x,int &root)
{
	int y = rbt[x].lc;
	rbt[x].lc = rbt[y].rc;
	if (rbt[y].rc != nil) rbt[rbt[y].rc].fa = x;
	rbt[y].fa = rbt[x].fa;
	if (rbt[x].fa == nil) root = y; //no one node points to y
	else if (x == rbt[rbt[x].fa].lc) rbt[rbt[x].fa].lc = y;
	else rbt[rbt[x].fa].rc = y;
	rbt[x].fa = y;
	rbt[y].rc = x;
	update(x);
	update(y);
}
void insertfixup(int z,int &root)
{
	while (rbt[rbt[z].fa].col == RED) // rbt[z].fa cannot be the root since color[root]=BLACK always;
	{
		if (rbt[z].fa == rbt[rbt[rbt[z].fa].fa].lc)
		{
			int w = rbt[rbt[rbt[z].fa].fa].rc;
			if (rbt[w].col == RED)
			{
				rbt[rbt[z].fa].col = rbt[w].col = BLACK;
				rbt[rbt[rbt[z].fa].fa].col = RED;
				z = rbt[rbt[z].fa].fa; //rbt[z].col=RED; only this case changes the value of z
			}
			else //rbt[w].col==BLACK;
			{
				if (z == rbt[rbt[z].fa].rc) { z = rbt[z].fa; LR(z,root); } //leftsrotate(z)   so that z==rbt[rbt[z].fa].lc 
				rbt[rbt[z].fa].col = BLACK;
				rbt[rbt[rbt[z].fa].fa].col = RED;
				RR(rbt[rbt[z].fa].fa,root);    //once it is implementated it will break out of the while loop 
				//so there are at most two rotatation LR & RR	
			}
		}
		else //rbt[z].fa==rbt[rbt[rbt[z].fa].fa].rc
		{
			int w = rbt[rbt[rbt[z].fa].fa].lc;
			if (rbt[w].col == RED)
			{
				rbt[rbt[z].fa].col = rbt[w].col = BLACK;
				rbt[rbt[rbt[z].fa].fa].col = RED;
				z = rbt[rbt[z].fa].fa; //rbt[z].col=RED;
			}
			else //rbt[w].col==BLACK
			{
				if (z == rbt[rbt[z].fa].lc) { z = rbt[z].fa; RR(z,root); }
				rbt[rbt[z].fa].col = BLACK;
				rbt[rbt[rbt[z].fa].fa].col = RED;
				LR(rbt[rbt[z].fa].fa,root);
			}
		}
	}
	rbt[root].col = BLACK; //maintain ROOT BLACK
}
void insert(int v,int &root)
{
	int y = nil;
	int x = root;
	while (x != nil)
	{
		rbt[x].size++;
		y = x;
		if (v < rbt[x].key) x = rbt[x].lc; else x = rbt[x].rc;
	}
	rbt[++tot].fa = y; rbt[tot].lc = rbt[tot].rc = nil;;
	rbt[tot].key = v; rbt[tot].size = 1;
	if (y == nil) root = tot;
	else if (v < rbt[y].key) rbt[y].lc = tot; else rbt[y].rc = tot;
	rbt[tot].col = RED; //red 
	insertfixup(tot,root);
}

int getKth(int x, int now)
{
	if (rbt[rbt[x].lc].size >= now) return getKth(rbt[x].lc, now);
	if (rbt[rbt[x].lc].size + 1 == now) return x;
	return getKth(rbt[x].rc, now - rbt[rbt[x].lc].size - 1);
}
typedef vector<int>::iterator VITER;
int n, nx, ny, m, xa, xb, xc, xd;
struct rec
{
	int l, r;
	int root;
}*tree;
vector<int> tx;
vector<int> ty;
int tt;
void dfs(int x, int &root)
{
	if (x == nil) return;
	insert(rbt[x].key, root);
	if (rbt[x].lc != nil) dfs(rbt[x].lc, root);
	if (rbt[x].rc != nil) dfs(rbt[x].rc, root);
}
void init(int f, int t, int x)
{
	tree[x].l = f; tree[x].r = t; tree[x].root = 0;
	if (f == t)
	{
		int ll = 1, rr = n, res1, res2;
		while (ll <= rr)
		{
			int mid = (ll + rr) >> 1;
			if (a[mid].x<f) ll = mid + 1;
			else if (a[mid].x>f) rr = mid - 1;
			else { res1 = mid; rr = mid - 1; }
		}
		ll = 1; rr = n;
		while (ll <= rr)
		{
			int mid = (ll + rr) >> 1;
			if (a[mid].x<f) ll = mid + 1;
			else if (a[mid].x>f) rr = mid - 1;
			else { res2 = mid; ll = mid + 1; }
		}		
		for (int i = res1; i <= res2; i++)
		{			
			insert(a[i].y,tree[x].root);
		}		
		return;
	}
	init(f, (f + t) >> 1, x << 1);
	init(((f + t) >> 1) + 1, t, (x << 1)+ 1);
	dfs(tree[x << 1].root,tree[x].root);
	dfs(tree[(x << 1)+1].root, tree[x].root);	
}
int findx(int x)
{
	int l = 1, r = nx,ret=-1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (x >= tx[mid]) { ret = mid; l = mid + 1; }
		else r = mid - 1;
	}
	return ret;
}
int findy(int y)
{
	int l = 1, r = ny,ret=-1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (y <= ty[mid]) { ret = mid; r = mid - 1;  }
		else l = mid + 1;	
	}
	return ret;
}
int findxa(int x)
{
	int l = 1, r = nx, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (x <= tx[mid]) { ret = mid; r = mid - 1; }
		else l = mid + 1;
	}
	return ret;
}
int findxc(int x)
{
	int l = 1, r = nx, ret = -1;
	while (l <= r)
	{
		int mid = (l + r) >> 1;
		if (x >= tx[mid]) { ret = mid; l = mid + 1; }
		else r = mid - 1;
	}
	return ret;
}
void findminbiggerorequal(int x, int rank,int &ret)
{
	if (x == nil) return;
	if (ty[rbt[x].key] >= xb)
	{
		ret = rank + rbt[rbt[x].lc].size + 1;
		findminbiggerorequal(rbt[x].lc, rank, ret);
	}
	else
	{
		findminbiggerorequal(rbt[x].rc, rank + rbt[rbt[x].lc].size + 1, ret);
	}
}
void findmaxlessorequal(int x, int rank, int &ret)
{
	tt++;
	if (x == nil) return;
	if (ty[rbt[x].key] <= xd)
	{
		ret = rank + rbt[rbt[x].lc].size + 1;
		findmaxlessorequal(rbt[x].rc, rank + rbt[rbt[x].lc].size + 1, ret);
	}
	else
	{
		findmaxlessorequal(rbt[x].lc, rank, ret);
	}
}
int query(int f, int t, int x)
{
	tt++;
	if (f <= tree[x].l && tree[x].r <= t)
	{
		int res1=-1, res2=-1;
		findminbiggerorequal(tree[x].root, 0, res1);
		if (res1 == -1) return 0;
		findmaxlessorequal(tree[x].root, 0, res2);
		if (res2 == -1) return 0;
		if (res2 < res1) return 0;
		return res2-res1+1;
	}
	int mid = (tree[x].l + tree[x].r) >> 1;
	int res = 0;
	if (f <= mid) res = query(f, t, x << 1);

	if (t>mid) res += query(f, t, (x << 1) + 1);
	return res;
}
bool cmp(data u, data v)
{
	return (u.x<v.x || (u.x == v.x && u.y<v.y));
}

int main()
{
	freopen("1.in", "r", stdin);
	freopen("2.out", "w", stdout);
	scanf("%d", &n);
	a = (data *)malloc(sizeof(data)*n);
	double t = ceil(log(n) / log(2));
	int node = (t + 2)*(n + 1);
	rbt = (RBTree *)malloc(sizeof(RBTree)*node);
	tree = (rec*)malloc(sizeof(rec)*node);
	tx.push_back(-1);
	ty.push_back(-1);
	for (int i = 1; i <= n; i++) { scanf("%d %d", &a[i].x, &a[i].y); tx.push_back(a[i].x); ty.push_back(a[i].y); }
	sort(tx.begin() + 1, tx.end());
	sort(ty.begin() + 1, ty.end());
	VITER it;
	it = unique(tx.begin(), tx.end());
	tx.erase(it, tx.end());
	it = unique(ty.begin(), ty.end());
	ty.erase(it, ty.end());
	nx = tx.size() - 1;
	ny = ty.size() - 1;
	for (int i = 1; i <= n; i++)
	{
		a[i].x = findx(a[i].x);
		a[i].y = findy(a[i].y);
	}
	sort(a + 1, a + n + 1, cmp);
	initrbtree();
	init(1, nx, 1);
	scanf("%d", &m);
	long long TTT=0;
	for (int i = 1; i <= m; i++)
	{
		scanf("%d %d %d %d", &xa, &xb, &xc, &xd);		
		int l1, r1;		
		l1 = findxa(xa);
		r1 = findxc(xc);
		//if (l1 > r1 || l1 <= 0 || l1>nx || r1>nx) { printf("0\n"); continue; }
		tt = 0;
		int ans = query(l1, r1, 1);
		TTT += (long long)tt;
		//cout <<i<<" : "<< tt << "\n";
		printf("%d\n", ans);
	}
	TTT /= m;
	cout << TTT << "\n";
	return 0;
}
