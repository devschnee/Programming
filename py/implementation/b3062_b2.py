t = int(input())
for i in range(t):
    n = int(input())
    n2 = str(n)[::-1]
    tot = n + int(n2)
    if str(tot) == str(tot)[::-1]:
        print("YES")
    else:
        print("NO")