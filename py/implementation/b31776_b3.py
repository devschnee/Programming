#31776 B3 예비 소집 결과 보고서
import sys
input = sys.stdin.readline

n = int(input())
cnt = 0

for _ in range(n):
    p = list(map(int, input().split()))
    
    # 일단 첫 번째 숫자가 -1이면 무조건 탈락
    if p[0] == -1:
        continue
    
    # 조건을 검사(앞 숫자보다 작아지면 탈락)
    # 단, 뒤의 숫자가 -1이면 비교하지 않고 통과(True)로 간주
    
    # 첫 번째 vs 두 번째
    a = (p[1] == -1) or (p[0] <= p[1])
    
    # 두 번째 vs 세 번째
    # 두 번째가 -1이면 세 번째도 무조건 -1이어야 함 (숫자가 다시 나오면 안 됨)
    if p[1] == -1:
        b = (p[2] == -1)
    else:
        b = (p[2] == -1) or (p[1] <= p[2])
        
    if a and b:
        cnt += 1

print(cnt)