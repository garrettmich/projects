puts "What is the length of your garden box?"
length = gets.chomp.to_i
puts "What is the width of your garden box?"
width = gets.chomp.to_i
area = length * width
puts "The area of your garden box is " + area.to_s + " and the perimeter of your garden box is #{2 * (length + width)}"

carrots = area
corn = ((3/16.0) * area).floor
beets = ((9/16.0) * area).floor

puts "You can plant #{carrots} carrots, #{corn} corn, and #{beets} beets."

#as long as one of those numbers as a decimal > either 3.0 9.0 or 16.0 - it tells it that there will be an decimal coming up.
