# b10773 S4 제로
import sys
input = sys.stdin.readline
k = int(input())
l = []
h = 0
for i in range(k):
    n = int(input())
    if n == 0:
        if l:
            l.pop()
    else:
        l.append(n)
for i in l:
    h += i
print(h)