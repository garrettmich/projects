require 'git_practice_class'

describe Sorting_num do
  describe "sorted" do
    context "given the numbers 7, 3, 8, 5, & 1" do
      it "returns 1, 3, 5, 7, 8" do
        my_class = Sorting_num.new
        num = [7, 3, 8, 5, 1]
        expect(my_class.sorted(num)).to eql([1, 3, 5, 7, 8])
      end
    end
  end
end
