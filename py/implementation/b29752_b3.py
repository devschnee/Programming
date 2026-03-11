#b29752 최장 스트릭
import sys
input = sys.stdin.readline
n = int(input())
s = input().split()

cnt = 0
t = []

for i in s:
    if i == "0":
        t.append(cnt)
        cnt = 0
    else:
        cnt += 1
t.append(cnt)
print(max(t))