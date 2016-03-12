#include "stdafx.h"
#include<cstdio>
#include<cstdlib>
#include<cstring>
#include<algorithm>
#include<iostream>
#include<cmath>
#include<stack>
#include<queue>
#include<ctime>
#define eps 1e-8
#define maxn 31111111
using namespace std;
struct rec
{
	int d[2];
}a[maxn], b[maxn];
struct kdtype
{
	int d[2];
	int split, lc, rc;
}kd[maxn];
int n, m, root,nown, nowi, tot, nowsplit, kmin,target[2], vis[maxn],used[maxn];
stack<int> stk;
int cmps(double t)
{
	if (t> eps) return 1;
	if (t<-eps) return -1;
	return 0;
}
struct T
{
	int d[2];
	double dis;
	friend bool operator <(const T &t1, const T &t2)
	{
		return cmps(t1.dis - t2.dis) < 0;
	}
	T(){}
	T(int u, int v, double distance){ d[0] = u; d[1] = v; dis = distance; }
}ans[maxn];
priority_queue<T> q;
bool cmp(rec t1, rec t2)
{
	return t1.d[nowsplit] < t2.d[nowsplit] || (t1.d[nowsplit] == t2.d[nowsplit] && t1.d[nowsplit ^ 1] < t2.d[nowsplit ^ 1]);
}
void createkdtree(int ll, int rr, int split, int x)
{
	nowsplit = split;
	sort(a + ll, a + rr + 1, cmp);
	kd[x].split = split;
	int mid = (rr - ll + 2) / 2 + ll - 1;
	while (mid < rr && a[mid].d[split] == a[mid + 1].d[split]) mid++;
	kd[x].d[0] = a[mid].d[0]; kd[x].d[1] = a[mid].d[1];
	kd[x].lc = 0; kd[x].rc = 0;
	if (ll == rr) return;
	if (mid - 1 >= ll)
	{
		kd[x].lc = ++tot;
		createkdtree(ll, mid - 1, split ^ 1, kd[x].lc);
	}
	if (mid + 1 <= rr)
	{
		kd[x].rc = ++tot;
		createkdtree(mid + 1, rr, split ^ 1, kd[x].rc);
	}
}
void init(FILE *fin)
{
	fscanf(fin, "%d", &n);
	for (int i = 1; i <= n; i++) { fscanf(fin, "%d %d", &a[i].d[0], &a[i].d[1]); b[i].d[0] = a[i].d[0]; b[i].d[1] = a[i].d[1]; }
	nowsplit = 0;
	sort(b + 1, b + n + 1, cmp);
	int j = 1, tn = 0;
	while (j <= n)
	{
		int k = j;
		while (k + 1 <= n && b[k + 1].d[0] == b[j].d[0] && b[k + 1].d[1] == b[j].d[1]) k++;
		a[++tn].d[0] = b[j].d[0];
		a[tn].d[1] = b[j].d[1];
		j = k + 1;
	}
	for (int i = tn + 1; i <= n; i++) a[i].d[0] = a[i].d[1] = 0;
	n = tn;
	root = tot = 1;
	createkdtree(1, n, 0, 1);
}

double dist(int *p1, int *p2)
{
	return sqrt(pow((p1[0] - p2[0])/10000000.0, 2) + pow((p1[1] - p2[1])/1000000.0, 2));
}
void dfs2(int x, int &nearest, double &mind)
{
	if (!x) return;
	//cout << kd[x].d[0] << " " << kd[x].d[1]<<" "<<kd[x].split<<"\n";
	stk.push(x);
	vis[x] = nowi;
	int s = kd[x].split;
	if (kd[x].d[0] == target[0] && kd[x].d[1] == target[1])
	{
		nearest = x;
		mind = 0.0;
	}
	if (target[s] <= kd[x].d[s]) dfs2(kd[x].lc, nearest, mind);
	else if (target[s]>kd[x].d[s]) dfs2(kd[x].rc, nearest, mind);
}
void findnearest(FILE *fout)
{
	int x = root;
	int nearest = -1;
	double mind = 0x7FFFFFFF;
	dfs2(x, nearest, mind);
	if (nearest == -1)
	{
		nearest = stk.top();
		mind = dist(kd[nearest].d, target);
	}
	while (!q.empty()) q.pop();
	q.push(T(kd[nearest].d[0], kd[nearest].d[1], mind));
	used[nearest] = nowi;
	nown = 1;
	while (!stk.empty())
	{
		int bp = stk.top();
		stk.pop();
		double maxd = q.top().dis;
		if (kd[bp].lc == 0 && kd[bp].rc == 0)
		{			
			if (used[bp]!=nowi && (nown < kmin || cmps(dist(kd[bp].d, target) - maxd) < 0))
			{
				used[bp] = nowi;
				if (nown == kmin) q.pop();
				q.push(T(kd[bp].d[0], kd[bp].d[1], dist(kd[bp].d, target)));
				if (nown<kmin) nown++;
			}			   
		}
		else
		{
			int s = kd[bp].split;
			int psearch;
			if (target[s] <= kd[bp].d[s])
			{
				psearch = kd[bp].lc;
				if (psearch && vis[psearch] != nowi) stk.push(psearch);
				if ( (nown<kmin || cmps(abs(kd[bp].d[s] - target[s]) - maxd) < 0))
				{
					psearch = kd[bp].rc;
					if (psearch && vis[psearch] != nowi) stk.push(psearch);
				}
			}
			else
			{
				psearch = kd[bp].rc;
				if (psearch && vis[psearch] != nowi) stk.push(psearch);
				if ( (nown<kmin || cmps(abs(kd[bp].d[s] - target[s]) - maxd) < 0))
				{
					psearch = kd[bp].lc;
					if (psearch && vis[psearch] != nowi) stk.push(psearch);
				}
			}
			if (used[bp]!=nowi && (nown<kmin || cmps(dist(kd[bp].d, target) - maxd) < 0))
			{
				used[bp] = nowi;
				if (nown == kmin) q.pop();
				q.push(T(kd[bp].d[0], kd[bp].d[1], dist(kd[bp].d, target)));
				if (nown<kmin) nown++;
			}
		}
	}	
	int cnt = 0;
	while (!q.empty())
	{
		ans[++cnt] = q.top();		
		q.pop();
	}
	fprintf(fout, "%d\n",cnt);
	fprintf(fout, "%d %d\n", target[0], target[1]);
	for (int i = cnt; i >= 1; i--)
	{
		fprintf(fout, "%d %d %.8f\n", ans[i].d[0], ans[i].d[1], ans[i].dis);
	}
}
int main()
{
	clock_t start, finish;
	double duration;
	start = clock();
	FILE *fin = fopen("1.txt", "r");
	init(fin);
	fclose(fin);		
	finish = clock();
	duration = (double)(finish - start) / CLOCKS_PER_SEC;
	cout << "Initialization takes  " << duration << " s\n";
	cout << "Run the program?(Y/N)\n";
	char ch = getchar();
	while (ch == 'y' || ch == 'Y')
	{
		start = clock();
		FILE *fout = fopen("2.out", "w");
		fin = fopen("query.in", "r");
		fscanf(fin, "%d", &m);
		for (int i = 1; i <= m; i++)
		{
			nowi = i;
			nown = 0;
			fscanf(fin, "%d %d %d", &kmin, &target[0], &target[1]);
			findnearest(fout);
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
