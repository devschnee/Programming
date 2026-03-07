T = int(input());
for i in range(T):
  s = input().rstrip() 
  # .rstrip()는 문자열의 오른쪽 끝에 있는 공백을 제거하는 메서드.
  st = list()
  for c in s:
    if c == '(':
      st.append(c)
    else:
      if not st:
        st.append(c)
        break
      st.pop()
  print("YES" if not st else "NO")