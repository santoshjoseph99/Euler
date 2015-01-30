

class Integer
  N_BYTES = [42].pack('i').size
  N_BITS = N_BYTES * 16
  MAX = 2 ** (N_BITS - 2) - 1
  MIN = -MAX - 1
end

def is_prime_helper(x, n)
	return true if x == n
	return false if x % n == 0
	return is_prime_helper(x, n+1)
end

def is_prime(n)
	return true if n == 0 || n == 1 || n == 2
	for x in 2..(Math.sqrt(n))
		#return true if x == n
		return false if n % x == 0
	end
	return true
	#return is_prime_helper(n, 2)
end

def get_next_prime(n)
	for i in (n+1)..Integer::MAX
		return i if is_prime(i)
	end
end

def get_factors(n)
	factors = Array.new
	prime = 1
	while true
		prime = get_next_prime prime
		#print " ", prime, "\n"
		if n % prime == 0
			factors.push prime
			n = n / prime
			prime = 1
		end
		return factors if n == 1
	end
end

def check_next_numbers(num,len,count)
	for i in 1..count
		factors = get_factors(num+i).uniq
		#print "--", num+i, "-", factors,"\n"
		return false if factors.length != len
	end
	return true
end

def distinct_primes_factors
	for num in 647..Integer::MAX #647
		factors = get_factors(num).uniq
		if factors.length == 4
			print num, "-", factors, "\n"
			if check_next_numbers(num,4,3)
				return num
			end
		end
	end
	return 0
end

#temp = get_factors(21)
#print temp, " ", temp.length, "\n"
#print remove_duplicates(temp), "\n"

#print check_next_numbers(644,3,2), "\n"

#print is_prime(8178),"\n"

print distinct_primes_factors, "\n"
