from random import randint


def get_file(x,y):
    with open("numbers.txt", "w", encoding="utf-8") as file:
         for i in range(x):
             for n in range(y):
                 numbers = randint(-100, 100)
                 print(numbers, end="\t")
                 file.write(str(numbers) + " ")
             print(" ")
             file.write("\n")



def Task2():
    height = int(input("Введите ширину - "))
    width = int(input("Введите высоту - "))
    get_file(width, height)
      

Task2()    