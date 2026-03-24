# B1181 S5 단어정렬
n = int(input())
l = []
for i in range(n):
    l.append(input())
l = list(set(l))
l.sort(key=lambda x: (len(x), x))
for i in range(len(l)):
    if i == len(l) - 1:
        print(l[i], end="")
    else:
        print(l[i])