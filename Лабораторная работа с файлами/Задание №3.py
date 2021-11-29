def read_file(column):
    with open("numbers.txt", "r", encoding="utf-8") as file:
        text = file.readlines()
        lines = []      
        for i in text:
            nums = i.strip().split("\t")
            lines.append(nums)
        with open("sorted.txt", "w", encoding="utf-8") as file:
            for i in sorted(lines, key=lambda item: item[column-1]):
                for n in range(len(i)):
                    if n != len(i) - 1:
                       file.write(str(i[n]) + "\t")
                    else:
                       file.write(str(i[n]) + "\n")  
        

def Task3():
    column = int(input("Введите столбец - "))
    read_file(column)
         

Task3()    

