#Part 1: go from a word and translate into morse code
#Part 2: go from morse code into a word


#This is a hash that links each character (KEY) to its corresponding Morse code (Value)
#Basically equivalent of a dictionary
#Below is the hash
#in this example, the key is the letter and the morse code is the value
letters = {'a'=>".-",'b'=>"-...",'c'=>"-.-.",'d'=>"-..",'e'=>".",'f'=>"..-.",'g'=>"--.",'h'=>"....",'i'=>"..",'j'=>".---",'k'=>"-.-",'l'=>".-..",'m'=>"--",'n'=>"-.",'o'=>"---",'p'=>".--.",'q'=>"--.-",'r'=>".-.",'s'=>"...",'t'=>"-",'u'=>"..-",'v'=>"...-",'w'=>".--",'x'=>"-..-",'y'=>"-.--",'z'=>"--..",' '=>" ",'.'=>".-.-.-"}

puts "What type of conversion do you want to do? 1: Convert to Morse Code 2: Convert to English"
answer = gets.to_i

if answer == 1
		puts "What is your message in English?"
		message = gets.chomp.downcase
		translatedString = ""
		#This is an each char loop. It iterates over each character in the string. For each iteration the character we are on (each letter) is being refernced
		message.each_char do |i|
																												#the     <<" " at the end adds a space after each letter
				translatedString = translatedString+letters[i]+" "
		end
elsif answer==2
		puts "What is your message in Morse Code. (Place Spaces Between Characters)"
		message = gets.chomp
		translatedString = ""
#want to create a symbol for two spaces to have it act differently than single spaces and be easy to see in our hash
		while message.include? "  "

				message = message.sub("  ", " + ")
		end
		message = message.split
		message.each do |i|
				if(i=="+")

								translatedString = translatedString+" "

				else

						translatedString = translatedString+letters.key(i)

				end
		end
else
		puts "WRONG! That is an incorrect response and fake news"
end
puts translatedString
