# b27065 2002년이 아름다웠던 이유
import sys
input = sys.stdin.readline

t = int(input())
for _ in range(t):
    n = int(input())
    tot_ex_n = 0
    divisors = []

    for i in range(1, n):
        if n % i == 0:
            if i < n: # 자기 자신 제외
                tot_ex_n += i
                divisors.append(i)

    # n이 과잉수인지 확인
    if tot_ex_n <= n:
        print("BOJ 2022")
        continue # 과잉수 아니면 바로 다음 케이스로

    # 모든 약수가 부족수/완전수인지 검사
    is_perfect = True
    for d in divisors:
        tot_ex_d = 0
        # 각 약수 d의 진약수 합 구하기
        for j in range(1, d):
            if d % j == 0:
                tot_ex_d += j

        # 만약 약수 중에 과잉수가 있다면, n은 완전수/부족수가 아님
        if tot_ex_d > d:
            is_perfect = False
            break

    if is_perfect:
        print("Good Bye")
    else:
        print("BOJ 2022")