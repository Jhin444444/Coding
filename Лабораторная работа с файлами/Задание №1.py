def get_summa():
    with open("numbers.txt") as file:
        print(sum(map(int, file.readline().split())))


