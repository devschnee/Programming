import sys
input = sys.stdin.readline
N = int(input())
q = list()
for i in range(N):
    s = input().split()
    op = s[0]
    if op == 'push':
        q.append(s[1])
    elif op == 'pop':
        print(q.pop(0) if q else -1)  # 큐는 선입선출이므로 pop(0)으로 첫 번째 요소를 제거. pop()은 리스트의 마지막을 제거함.
    elif op == 'size':
        print(len(q))
    elif op == 'empty':
        print(0 if q else 1)
    elif op == 'front':
        print(q[0] if q else -1)
    elif op == 'back':
        print(q[-1] if q else -1)
