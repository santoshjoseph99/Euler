require 'bitarray'


def sieve_of_eratosthenes(e)
  b = BitArray.new(e)
  i = 2
  while i < Math.sqrt(e)
    m = 2
    while i*m <= e
      b[i*m] = 1
      m += 1
    end
    i += 1
    while b[i] == 1
      i += 1
    end
  end
  #puts b.to_s
  result = []
  for n in 2..e
    result << n if b[n] == 0
  end
  result
end

def get_array_sum(a, s, e)
  sum = 0
  s.upto(e){ |i| sum += a[i] }
  sum
end

def get_consecutive_prime_sum(a, n)
  i = a.index n
  max_length = 0
  for x in 0..i
    sum = get_array_sum a, x, i
    if sum == n && (i-x) >= max_length
      max_length = (i-x) 
    end
  end
  
  i.downto(0) do |x|
    sum = get_array_sum a, 0, x
    if sum == n && x >= max_length
      max_length = x
    end
  end

  s = 0
  e = i
  while s < e
    sum = get_array_sum a, s, e
    if sum == n && (s-e) >= max_length
      max_length = s-e
    end
    s += 1
    e -= 1
  end

  max_length
end

def consecutive_prime_sum(n2)
  primes = sieve_of_eratosthenes(n2)
  max_length = 0
  prime_num = 0
  for x in primes
    length = get_consecutive_prime_sum(primes,x)
    if length >= max_length
      max_length = length
      prime_num = x
    end
  end
  puts max_length
  prime_num
end

puts sieve_of_eratosthenes(100000).length

#puts consecutive_prime_sum(1000000)
