#1920 수 찾기

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