#Ask about garden box, tell them how many of whatever will be there
puts "What is the length of your garden box?"
length = gets.chomp.to_i
puts "What is the width of your garden box?"
width = gets.chomp.to_i

area = length * width

puts "Your perimeter is #{(length * 2) + (width * 2)} and your area is #{area}."

puts "What are you planting? corn, carrots, or beets?"
answer = gets.chomp.downcase #downcase or upcase to designate a specific case

if answer == "corn"
  puts "You can plant #{area/16 * 3} corn."
end
if answer == "carrots"
  puts "You cant plant #{area/16 * 16} carrots."
end
if answer == "beets"
  "You can plant #{area/16 * 9} beets."
end
