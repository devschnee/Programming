#5575 타임 카드
import sys;
input = sys.stdin.readline;
for i in range(3):
  arr = list(map(int, input().split()))
  s = arr[0:3]
  e = arr[3:6]
  if s[2] > e[2]:
    e[1] -= 1
    e[2] += 60
  if s[1] > e[1]:
    e[0] -= 1
    e[1] += 60
  h = e[0] - s[0]
  m = e[1] - s[1]
  s = e[2] - s[2]
  print(f"{h} {m} {s}")