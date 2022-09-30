from turtle import right


def merge(a, b):
    '''
    функция слияния двух отсортированных списков
    возвращает общий отсортированный список
    переписать функцию без рекурсии
    циклом, сложность равна n
    '''
    if a == [] or b == []: return a + b
    if a[0] < b[0]:
        return [a[0]] + merge(a[1:], b)
    else:
        return [b[0]] + merge(a, b[1:])


def sort_merge(lst):
    if len(lst) < 2: return lst
    middle = len(lst) // 2
    left = sort_merge(lst[:middle])
    right = sort_merge(lst[middle:])
    return fixed_merge(left, right)


def fixed_merge(a, b):
    if a == [] or b == []: return a + b
    else:
        a = []
        b = []
        for i in a:
            if i[0] < b[0]:
                a.append([i[0]])
        for i in b:
            if a[0] > i[0]:
                b.append([i[0]])
   
    
def sort_quick(lst):
    '''
    переписать эту функцию так
    чтобы не было три цикла
    за один цикл выбрать меньшие, большие и равные pivot
    '''
    if len(lst) < 2: return lst
    pivot = lst[0]
    left = list(filter(lambda x: x < pivot, lst))
    middle = list(filter(lambda x: x == pivot, lst))
    right = list(filter(lambda x: x > pivot, lst))
    return sort_quick(left) + middle + sort_quick(right)


def fixed_sort_quick(lst):
    if len(lst) < 2: return lst
    else:
        pivot = lst[0]
        left = []
        middle = []
        right = []
        for i in lst:
            if i < pivot:
                left.append(i)
            elif i > pivot:
                right.append(i)
            else:
                middle.append(i)  
        return fixed_sort_quick(left) + middle + fixed_sort_quick(right)             