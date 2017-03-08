puts "Hello, what is your name?"
gets
puts "How old are you?"
age = gets.to_i
puts "In five years, you will be #{age + 5}"

#or + (age + 5).to_s
