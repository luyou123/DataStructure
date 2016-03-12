#include"stdafx.h"
#include<cstdio>
#include<cstdlib>
#include<cstring>
#include<algorithm>
#include<vector>
#include<set>
#include<iostream>
#include<cmath>
#define maxn 11111111
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
}a[maxn];
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
typedef vector<int>::iterator VITER;
int n, nx, ny, m, xa, xb, xc, xd;
int bit[maxn];
vector<int> tx;
vector<int> ty;
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
void init(int id)
{
	int ll = 1, rr = n, res1, res2;
	while (ll <= rr)
	{
		int mid = (ll + rr) >> 1;
		if (a[mid].x<id) ll = mid + 1;
		else if (a[mid].x>id) rr = mid - 1;
		else { res1 = mid; rr = mid - 1; }
	}
	ll = 1; rr = n;
	while (ll <= rr)
	{
		int mid = (ll + rr) >> 1;
		if (a[mid].x<id) ll = mid + 1;
		else if (a[mid].x>id) rr = mid - 1;
		else { res2 = mid; ll = mid + 1; }
	}
	for (int i = res1; i <= res2; i++)
	{		
		for (int x=id; x<= nx; x += x & -x)
		{
			insert(a[i].y, bit[x]);
		}
	}
}
int query(int x)
{
	int ans = 0;
	for (; x; x -= x & -x)
	{
		int res1 = -1, res2 = -1;
		findminbiggerorequal(bit[x], 0, res1);
		if (res1 == -1) continue;
		findmaxlessorequal(bit[x], 0, res2);
		if (res2 == -1) continue;
		if (res2 < res1) continue;
		ans += res2 - res1 + 1;
	}
	return ans;
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
	double t = ceil(log(n) / log(2));
	int node = (t + 2)*(n + 1);
	rbt = (RBTree *)malloc(sizeof(RBTree)*node);	
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
	for (int i = 1; i <= nx; i++)
		init(i);	
	scanf("%d", &m);
	for (int i = 1; i <= m; i++)
	{
		scanf("%d %d %d %d", &xa, &xb, &xc, &xd);		
		int l1, r1;		
		l1 = findxa(xa);
		r1 = findxc(xc);
		if (l1 > r1 || l1<=0 || l1>nx || r1>nx) { printf("0\n"); continue; }
		int ans;
		if (l1 == 1) ans = query(r1);
		else ans = query(r1)-query(l1-1);		
		printf("%d\n", ans);
	}
	return 0;
}
