class RomanConverter
  def convert (number) #defining a function
    result = ""
    @denominations.each do |denomination|
      while number >= denomination[:value]
        number -= denomination[:value]
        result << denomination[:name]
      end
    end
    result
    end

#Constructor/Initializer
  def initialize
    @denomination = []
    add_denomination("C", 100)
    add_denomination("XC", 90)
    add_denomination("L", 50)
