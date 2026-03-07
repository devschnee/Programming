# 백준 10828 스택
import sys

input = sys.stdin.readline
num = int(input())
st = list()
for i in range(num):
  s = input().split()
  op = s[0]
  if op == 'push':
    st.append(int(s[1]))
  elif op == 'pop':
    print(st.pop() if st else -1)
  elif op == 'size':
    print(len(st))
  elif op == 'empty':
    print(0 if st else 1)
  elif op == 'top':
    print(st[-1] if st else -1)