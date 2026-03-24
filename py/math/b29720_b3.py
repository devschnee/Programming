# b29720 b3 그래서 님 푼 문제 수가?
n, m, k = map(int, input().split())
res = (0, n-(m*(k-1)+1)) if n - m*k <= 0 else (n-m*k, n-(m*(k-1)+1))
print(*res)
# 파이썬에서는 리스트나 튜플 앞에 *을 붙이면 언패킹 해달라는 의미가 됨
# print((0, 5)) -> (0, 5)
# print(*(0, 5)) -> 0 5


# 다른 풀이 : f-string 사용해서 출력하기
'''
r1, r2 = (0, n-(m*(k-1)+1)) if n - m*k <= 0 else (n-m*k, n-(m*(k-1)+1))
print(f"{r1} {r2}")
'''

# 다른 풀이 : if-else문 사용해서 출력하기
n, m, k = map(int, input().split())
if n-m*k < 0:
    print(0, n - (m*(k-1) + 1))
else:
    print(n - m*k, n - (m*(k-1) + 1))