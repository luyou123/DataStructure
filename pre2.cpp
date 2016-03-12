// pre2.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include<cstdio>
#include<cstdlib>
#include<cstring>
#include<iostream>
#include<algorithm>
#include<ctime>
#define INF 0x7FFFFFFF
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
int fminx, fmaxx, fminy, fmaxy,root,tot,n,m,xa,xb,xc,xd,ans,tt,depth;
struct QTree
{
	int minx, miny, maxx, maxy,cminx,cminy,cmaxx,cmaxy, size,x,y,cnt,fa; //cnt useful branch
	int child[4];	
	QTree(){}
}*qt;
void initnode(QTree &T)
{
	T.size = T.x = T.y = T.cnt = T.fa = 0;
	T.cminx = T.cminy = INF;
	T.cmaxx = T.cmaxy = -1;
	T.child[0] = T.child[1] = T.child[2] = T.child[3] = 0;
}
int getquad(int node, int x, int y)
{	
	int midx = (qt[node].minx+qt[node].maxx)/2;
	int midy = (qt[node].miny+qt[node].maxy) / 2;
	if (midx < x && x <= qt[node].maxx && midy <= y && y <= qt[node].maxy)
	{
		return 0;
	}
	if (qt[node].minx <= x && x <= midx && midy <= y && y <= qt[node].maxy)
	{
		return 1;
	}
	if (qt[node].minx <= x && x <= midx && qt[node].miny <= y && y < midy)
	{
		return 2;
	}
	return 3;
}
void modifyquad(int tot, int node,int quad)
{
	int midx = (qt[node].minx + qt[node].maxx) / 2;
	int midy = (qt[node].miny + qt[node].maxy) / 2;
	switch (quad)
	{
	case 0: qt[tot].minx = midx; qt[tot].maxx = qt[node].maxx; qt[tot].miny = midy; qt[tot].maxy = qt[node].maxy; break;
	case 1: qt[tot].minx = qt[node].minx; qt[tot].maxx = midx; qt[tot].miny = midy; qt[tot].maxy = qt[node].maxy; break;
	case 2: qt[tot].minx = qt[node].minx; qt[tot].maxx = midx; qt[tot].miny = qt[node].miny; qt[tot].maxy = midy; break;
	case 3: qt[tot].minx = midx; qt[tot].maxx = qt[node].maxx; qt[tot].miny = qt[node].miny; qt[tot].maxy = midy; break;
	}
}
void build(int node, int x,int y)
{
	qt[node].size++;
	int quad = getquad(node,x, y);	
	if (!qt[node].child[quad]) //==0
	{
		qt[node].child[quad] = ++tot; 
		qt[node].cnt++;
		initnode(qt[tot]);
		modifyquad(tot, node, quad);
		qt[tot].size = 1;
		qt[tot].x = x; qt[tot].y = y;
		qt[tot].cnt = 0; 
		qt[tot].fa = node;
		qt[tot].cminx = qt[tot].cmaxx = x;
		qt[tot].cminy = qt[tot].cmaxy = y;
	}
	else
	{
		if (qt[qt[node].child[quad]].cnt == 0)
		{
			if (qt[qt[node].child[quad]].x == x && qt[qt[node].child[quad]].y == y)
			{
				qt[qt[node].child[quad]].size++;
				return;
			}
			int quad2 = getquad(qt[node].child[quad], qt[qt[node].child[quad]].x, qt[qt[node].child[quad]].y);
			qt[qt[node].child[quad]].child[quad2] = ++tot;
			qt[qt[node].child[quad]].cnt++;
			initnode(qt[tot]);
			modifyquad(tot, qt[node].child[quad], quad2);
			qt[tot].size = 1;
			qt[tot].x = qt[qt[node].child[quad]].x;
			qt[tot].y = qt[qt[node].child[quad]].y;
			qt[tot].cnt = 0;
			qt[tot].fa = qt[node].child[quad];
			qt[tot].cminx = qt[tot].cmaxx = qt[tot].x;
			qt[tot].cminy = qt[tot].cmaxy = qt[tot].y;
		}
		build(qt[node].child[quad], x, y);
	}
	for (int i = 0; i < 4; i++)
	{
		if (qt[node].child[i])
		{
			qt[node].cminx = min(qt[node].cminx, qt[qt[node].child[i]].cminx);
			qt[node].cminy = min(qt[node].cminy, qt[qt[node].child[i]].cminy);
			qt[node].cmaxx = max(qt[node].cmaxx, qt[qt[node].child[i]].cmaxx);
			qt[node].cmaxy = max(qt[node].cmaxy, qt[qt[node].child[i]].cmaxy);
		}
	}
}
void dfs(int node,int d)
{
	if (d > depth) depth = d;
	cout << node << "\n [" << qt[node].minx << " , " << qt[node].miny << "] - > [" << qt[node].maxx << " , " << qt[node].maxy << " ] \n";
	cout << "size : " << qt[node].size << " cnt: " << qt[node].cnt << "\n";
	cout << "(" << qt[node].x << " , " << qt[node].y << " ) " << "\n";
	cout << " cover rect: " << " [" << qt[node].cminx << " , " << qt[node].cminy << "] - > [" << qt[node].cmaxx << " , " << qt[node].cmaxy << " ] \n------------------------\n";
	for (int i = 0; i < 4; i++)
	{
		if (qt[node].child[i]) dfs(qt[node].child[i],d+1);
	}
}
void preinit()
{
	scanf("%d", &n);
	a = (data *)malloc(sizeof(data)*n);
	fminx = fminy = INF;
	fmaxx = fmaxy = -1;
	for (int i = 1; i <= n; i++)
	{
		scanf("%d %d", &a[i].x, &a[i].y);
		fminx = min(fminx, a[i].x);
		fmaxx = max(fmaxx, a[i].x);
		fminy = min(fminy, a[i].y);
		fmaxy = max(fmaxy, a[i].y);
	}
	fminx = max(0, fminx - 2);
	fmaxx += 2;
	fminy = max(0, fminy - 2);
	fmaxy += 2;
	double t = ceil(log(fmaxx) / log(2));
	int nodenum = (t + 2)*(n + 1);
	qt = (QTree *)malloc(sizeof(QTree)*nodenum);
	root = tot = 1; 
	initnode(qt[1]);
	qt[1].minx = fminx; qt[1].miny = fminy; qt[1].maxx = fmaxx; qt[1].maxy=fmaxy;		
	for (int i = 1; i <= n; i++)
	{
		build(1, a[i].x, a[i].y);
	}
	depth = 0;
	//dfs(1,0);
	//cout << depth << "\n";
}
int query(int node)
{
	tt++;
	int lx = max(qt[node].cminx, xa), rx = min(qt[node].cmaxx, xc);
	int ly = max(qt[node].cminy, xb), ry = min(qt[node].cmaxy, xd);
	if (lx > rx || ly > ry) return 0;	
	int ret = 0;
	if (lx <= qt[node].cminx && qt[node].cmaxx <= rx && ly <= qt[node].cminy && qt[node].cmaxy <= ry) return qt[node].size;
	for (int i = 0; i < 4; i++) if (qt[node].child[i]) {
		ret += query(qt[node].child[i]); 
	}
	return ret;
}
int main()
{
	freopen("1.in", "r", stdin);
	freopen("2.out", "w", stdout);	
	preinit();
	scanf("%d", &m);
	srand(time(0));
	//cout << depth << "\n";
	for (int i = 1; i <= m; i++)
	{
		scanf("%d %d %d %d", &xa, &xb, &xc, &xd);
		tt = 0;
		ans=query(root);				
		printf("%d\n",ans);
	}
	return 0;
}
