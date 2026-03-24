#1920 수 찾기
"""
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
"""

#이진 탐색 이용해보기
import sys
input = sys.stdin.readline
N = int(input())
A = sorted(map(int, input().split()))  # 이진 탐색은 정렬 필수
M = int(input())
k = list(map(int, input().split()))

def binary_search(arr, target):
    left, right = 0, len(arr) - 1
    while left <= right:
        mid = (left + right) // 2
        if arr[mid] == target:
            return 1
        elif arr[mid] < target:
            left = mid + 1
        else:
            right = mid - 1
    return 0

for i in k:
    print(binary_search(A, i))