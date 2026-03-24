#1920 수 찾기
import sys
input = sys.stdin.readline
N = int(input())
A = set(map(int, input().split()))  # A를 집합으로 만들어서 탐색 속도를 O(1)로 개선. 리스트는 속도 O(n)로 탐색 함.

M = int(input())
k = list(map(int, input().split()))  # k는 리스트. 리스트는 순서가 있으므로 인덱스로 접근 가능.

for i in k:
  if i in A:
    print(1)
  else:
    print(0)