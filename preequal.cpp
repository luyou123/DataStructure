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
}*a,*b;
int root, tot, n, m, xa, xb, xc, xd, ans, tt, depth,cntb;
struct QTree
{
	int minx, miny, maxx, maxy, cminx, cminy, cmaxx, cmaxy, size; //cnt useful branch
	int child[4];
	QTree(){}
}*qt;
void initnode(QTree &T)
{
	T.size = 0;
	T.cminx = T.cminy = INF;
	T.cmaxx = T.cmaxy = -1;
	T.child[0] = T.child[1] = T.child[2] = T.child[3] = 0;
}
int getquad(int node, int x, int y)
{
	int midx = (qt[node].minx + qt[node].maxx) / 2;
	int midy = (qt[node].miny + qt[node].maxy) / 2;
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
void modifyquad(int tot, int node, int quad)
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
void dfs(int node)
{
	depth++;
	cout << node << "\n [" << qt[node].minx << " , " << qt[node].miny << "] - > [" << qt[node].maxx << " , " << qt[node].maxy << " ] \n";
	cout << "size : " << qt[node].size << " cnt: " <<  "\n";	
	cout << " cover rect: " << " [" << qt[node].cminx << " , " << qt[node].cminy << "] - > [" << qt[node].cmaxx << " , " << qt[node].cmaxy << " ] \n------------------------\n";
	for (int i = 0; i < 4; i++)
	{
		if (qt[node].child[i]) dfs(qt[node].child[i]);
	}
}
bool cmpx(data t1, data t2)
{
	return (t1.x < t2.x || (t1.x == t2.x && t1.y < t2.y));
}
bool cmpy(data t1, data t2)
{
	return (t1.y < t2.y || (t1.y == t2.y && t1.x < t2.x));
}
int dividex(int first, int last)
{
	int i = first, cnt=0, lcnt=0, xl=first;
	while (i <= last)
	{
		int j = i;		
		cnt++;
		while (j + 1 <= last && b[i].x == b[j + 1].x) { cnt++;  j++; depth++; }
		if (cnt <= (last - first + 1) / 2) { xl = j; lcnt = cnt; }
		else {
			if (cnt - (last - first + 1) / 2 < (last - first + 1) / 2 - lcnt)
			{
				xl = j;
				depth++;
				break;
			}
		}
		i = j + 1;
	}
	return xl;
}
int dividey(int first, int last)
{
	int i = first, cnt=0, lcnt=0, yl=first;
	while (i <= last)
	{
		int j = i;
		cnt = 0;
		cnt++;
		while (j + 1 <= last && b[i].y == b[j + 1].y) { cnt++;  j++; depth++;  }
		if (cnt <= (last - first + 1) / 2) { yl = j; lcnt = cnt; }
		else {
			if (cnt - (last - first + 1) / 2 < (last - first + 1) / 2 - lcnt)
			{
				depth++;
				yl = j;
				break;
			}
		}
		i = j + 1;
	}
	return yl;
}
void buildqtree(int node, int first, int last,int dp)
{
	depth++;
	initnode(qt[node]);
	qt[node].size = last - first + 1;
	sort(b + first, b + last + 1, cmpy);
	qt[node].miny = b[first].y; qt[node].maxy = b[last].y;
	sort(b + first, b + last + 1, cmpx);
	qt[node].minx = b[first].x; qt[node].maxx = b[last].x;
	if (qt[node].minx == qt[node].maxx && qt[node].miny == qt[node].maxy)
	{
		qt[node].cminx = qt[node].cmaxx = qt[node].minx;
		qt[node].cminy = qt[node].cmaxy = qt[node].miny;
		return;
	}
	int midx = dividex(first, last);	
	sort(b + first, b + midx + 1, cmpy);
	int midy1 = dividey(first, midx);
	sort(b + midx + 1, b + last + 1, cmpy);
	int midy2 = dividey(midx + 1, last);
	int l0,r0,l1,r1,l2,r2,l3,r3;
	for (int i = midy2 + 1; i <= last; i++)
	{
		depth++;
		b[++cntb] = b[i]; //area 0 
		if (i == midy2 + 1) l0 = cntb;
		r0 = cntb;
	}
	for (int i = midy1 + 1; i <= midx; i++)
	{
		depth++;
		b[++cntb] = b[i]; //area 1
		if (i == midy1 + 1) l1 = cntb;
		r1 = cntb;
	}
	for (int i = first; i <= midy1; i++)
	{
		depth++;
		b[++cntb] = b[i];    //area 2
		if (i == first) l2 = cntb;
		r2 = cntb;
	}
	for (int i = midx + 1; i <= midy2; i++)
	{
		depth++;
		b[++cntb] = b[i]; //area 
		if (i == midx + 1) l3 = cntb;
		r3 = cntb;
	}
	if (last >= midy2 + 1) { qt[node].child[0] = ++tot; buildqtree(qt[node].child[0], l0,r0,dp+1); }
	if (midx >= midy1 + 1) { qt[node].child[1] = ++tot; buildqtree(qt[node].child[1], l1,r1,dp+1); }
	if (midy1 >= first) { qt[node].child[2] = ++tot; buildqtree(qt[node].child[2], l2,r2,dp+1); }
	if (midy2 >= midx + 1) { qt[node].child[3] = ++tot;	buildqtree(qt[node].child[3], l3,r3,dp+1); }
	for (int i = 0; i < 4; i++)
	{
		depth++;
		if (qt[node].child[i])
		{
			qt[node].cminx = min(qt[node].cminx, qt[qt[node].child[i]].cminx);
			qt[node].cminy = min(qt[node].cminy, qt[qt[node].child[i]].cminy);
			qt[node].cmaxx = max(qt[node].cmaxx, qt[qt[node].child[i]].cmaxx);
			qt[node].cmaxy = max(qt[node].cmaxy, qt[qt[node].child[i]].cmaxy);
		}
	}
}
void preinit()
{
	scanf("%d", &n);
	a = (data *)malloc(sizeof(data)*n);	
	double t = ceil(log(n) / log(2));
	int nodenum = (t + 2)*(n + 1);
	qt = (QTree *)malloc(sizeof(QTree)*nodenum);
	b = (data *)malloc(sizeof(data)*nodenum);
	for (int i = 1; i <= n; i++)
	{
		scanf("%d %d", &a[i].x, &a[i].y);
		b[i].x = a[i].x; b[i].y = a[i].y;		
	}		
	root = tot = 1;		
	cntb = n;
	depth = 0;
	buildqtree(1, 1, n,0);			
	
}
int query(int node)
{
	tt++;
	int lx = max(qt[node].cminx, xa), rx = min(qt[node].cmaxx, xc);
	int ly = max(qt[node].cminy, xb), ry = min(qt[node].cmaxy, xd);
	if (lx > rx || ly > ry) return 0;
	int ret = 0;
	if (lx <= qt[node].cminx && qt[node].cmaxx <= rx && ly <= qt[node].cminy && qt[node].cmaxy <= ry) return qt[node].size;
	for (int i = 0; i < 4; i++) {
		if (qt[node].child[i]) ret += query(qt[node].child[i]); 
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
		ans = query(root);
//		printf("%d\n", ans);
		cout <<i<<" : "<< tt << "\n";

	}
	return 0;
}
