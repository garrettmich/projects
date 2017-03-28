#GIT PRACTICE WITH SORTING
class Sorting_num

def sorted num

puts "Let's sort some numbers for you! Right now, I have 7, 3, 8, 5, & 1.
\nBy pressing enter, I will preform a magic trick that lists these numbers in numerical order:\n"

#num = [7, 3, 8, 5, 1]

#use bubble sorting (it sorts numbers largest to smallest or smallest to largest)
#to put your numbers in incremintal order.
#p num.sort
num.each do |i|
  i = 0
  j = 1
  while (j < num.length)
    if num[i] > num[j]
      temp = num[i]
      num[i] = num[j]
      num[j] = temp
    end
  i+=1
  j+=1
  end
 end
   puts num
   return num
 end
end
=begin
  Array Sort

Given an unsorted integer array, return a sorted
version of the array. Sort can be highest to lowest
or lowest to highest.

Make sure to build tests for your code.

You may code this in any language you like.
=end
