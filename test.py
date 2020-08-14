# for i in range(1500,2500):
#     if (i % 7 == 0) and ( i % 5 == 0):
#         print(i,end = " ")

# i = 1
# sum = 0
# while i != 0:
#     num = int(input("Enter the number: "))
#     if num != 0 :
#         sum += num
#     else:
#         print("The total summation is ", sum)
#         break


# def different(n):
#     if n <= 17:
#         return (17-n)
#     else:
#         return (n -17)*2

# n = int(input("Enter the number: "))
# print(different(n))


# def sum(x, y, z):
#     sum = 0
#     if x == y == z:
#         sum = (x+y+z)*3
#     else:
#         sum = x + y + z
#     return sum

# print("Enter three numbers: ")
# a = int(input("a: "))
# b = int(input("b: "))
# c = int(input("c: "))
# print("The result: ",sum(a,b,c))


char = input("\nEnter the character or number: ")
alp = ord(char)
if alp >= 48 and alp <= 57:
    print("%s is a number.\n" % char)
elif alp >= 65 and alp <= 90:
    if char == 'A' or char == 'E' or char == 'I' or char == 'O' or char == 'U':
        print("%s is a vowel in uppercase.\n" % char)
    else:
        print("%s is a consonant in uppercase.\n"  % char)
elif alp >= 97 and alp <= 122:
    if char == 'a' or char == 'e' or char == 'i' or char == 'o' or char == 'u':
        print("%s is a vowel in lowercase.\n"  % char)
    else:
        print("%s is a consonant in lowercase.\n"  % char)
