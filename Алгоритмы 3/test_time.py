from timeit import default_timer as t
from random import randint as r
import sorts as s
import sys

sys.setrecursionlimit(30000)
count = 800000
lst = [r(0, 1000000) for _ in range(count)]
# print(lst[:10])

start = t()

# res = s.sort_merge(lst)

res = s.sort_merge(lst)

print("{0:.3f}".format(t() - start, 3))

# print(res[:10])