给定一个字符串， 求最长回文字串长度,  aba,  acbbca

def LongestHuiWen(s):
    left = 0
    right = len(s) - 1
    max = 0
    while left <=  right:
        if s[left] != s[right]:
            left += 1
            max = 0
        else:
            left += 1
            right -= 1
            max += 1
    

