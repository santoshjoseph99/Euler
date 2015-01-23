

def get_triangle(n)
	return (n * (n +1))/2
end

def get_pentagonal(n)
	return (n * (3*n -1))/2
end

def get_hexagonal(n)
	return n * (2*n - 1)
end

pentagonlStart = 166

triangle = 286
pentagonal = pentagonlStart
hexagonal = 144


triNum = 0
penNum = 0
hexNum = 0

while true do
	triNum = get_triangle(triangle)
	while penNum < triNum do
		penNum = get_pentagonal(pentagonal)
		pentagonal += 1
	end
	if penNum == triNum
		while hexNum < triNum do
			hexNum = get_hexagonal(hexagonal)
			hexagonal += 1
		end
	end
	#print triNum, " ", penNum, " ", hexNum, "\n"
	break if penNum == triNum && hexNum == triNum
	triangle += 1
end

print triNum
