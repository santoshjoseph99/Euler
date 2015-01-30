
class Integer
  N_BYTES = [42].pack('i').size
  N_BITS = N_BYTES * 16
  MAX = 2 ** (N_BITS - 2) - 1
  MIN = -MAX - 1
end

def is_prime_helper(x, n)
	return true if x == n
	return false if x % n == 0
	is_prime_helper(x, n+1)
end

def is_prime(n)
	return true if n == 0 || n == 1
	return is_prime_helper(n, 2)
end

def find_smaller_prime(n)
	return 0 if n < 4
	n.downto(3){ |i| return i if is_prime(i) }
	return 0
end

#print find_smaller_prime(34), "\n"
#print find_smaller_prime(4), "\n"
#print find_smaller_prime(3), "\n"

notfound = false
for num in 34..Integer::MAX
	if num % 2 == 1 && !is_prime(num)
		current = num
		while true
			found = false
			prime = find_smaller_prime(current-1)
			for square in 1..Integer::MAX
				break if square > num
				if (prime + 2 * ( square * square)) == num
					found = true
					break
				end
			end
			break if found == true
			if prime == 0
				notfound = true
				print "smallest odd composite: ", num, "\n"
				break
			end
			current = prime
		end
	end
	break if notfound == true
end

