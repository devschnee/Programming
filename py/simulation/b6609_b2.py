'''m이 알 e개 낳고 죽어. 알 하루만에 부화해.
알은 r의 비율로 부화해. 그래서 유충 돼.
저번 주에 부화한 유충은 죽거나 잡아먹혀. r번째 유충들만 일주일마다 번데기 돼. 번데기는 s의 비율로 성충 돼. 우리는 n주 후 모기 수를 구할거. 
'''
#6609 B2 모기곱셈
import sys
input = sys.stdin.readline
for line in sys.stdin:
    if not line.strip():
        break
    m, p, l, e, r, s, n = map(int, line.split())

    for _ in range(n):
        # 알 낳기(다음주 유충 될 거)
        new_l = m*e
        # 기존 유충 번데기
        new_p = l//r
        # 기존 번데기 성충
        new_m = p//s
         # 업데이트
        l = new_l
        p = new_p
        m = new_m
    print(m)