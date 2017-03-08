puts "Say... what month were you born in? No reason, just... curious."
month = gets.chomp.upcase

if month == "JANUARY" || month == "FEBRUARY" || month == "MARCH"
  puts "You were born in the Winter"
end
if month == "APRIL" || month == "MAY" || month == "JUNE"
  puts "You were born in the Spring!"
end
if month == "JULY" || month == "AUGUST" || month == "SEPTEMBER"
  puts "You were born in the Summer!"
end
if month == "OCTOBER" || month == "NOVEMBER" || month == "DECEMBER"
  puts "You were born in the Fall!"
end


=begin
spring =
summer =
fall =

case month.upcase
when "JANUARY"
when "FEBRUARY"
when "MARCH"
puts "Interesting. If my calculations are correct, you were born in winter."
end
=end
