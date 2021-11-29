def copy_palindroms():
    with open("Input.txt", "r", encoding="utf-8") as file:
        with open("Output.txt", "w", encoding="utf-8") as file1:
          for line in file.readlines(): 
            text = line  
            signs = "!?-+*= :;.," + "'" + '"' + "\n" 
            lines = []
            for i in text:
                if i not in list(signs):
                    lines.append(i)
            change_lines = ""            
            change_lines = change_lines.join(lines)
            change_lines = change_lines.lower()
            if change_lines == change_lines[::-1]:
                file1.write(line)         
            

copy_palindroms()                                  
         
