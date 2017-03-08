counter = 1
puts "This is FIZZBUZZ"

while counter < 100
  if counter % 15 == 0
    puts "FIZZBUZZ"
  elsif counter % 3 == 0
  puts "FIZZ"
  elsif counter % 5 == 0
    puts "BUZZ"
  else
    puts counter
end
  counter = counter + 1
end
