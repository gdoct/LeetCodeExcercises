use std::convert::TryFrom;

fn main() {
    let q = my_atoi("-6147483648".to_string());
    assert_eq!(-2147483648, q);
}


pub fn my_atoi(s: String) -> i32 {
    let input = s.trim();
    if input.is_empty() {
        return 0;
    }
    let inp = input.chars();
    let mut nums: Vec<i32> = Vec::new();
    let mut neg: bool = false;
    let mut found_digit: bool = false;
    let mut index: i32 = 0;
    for letter in inp {
        match letter {
            '-' => { if index ==0 { neg = true; } else { break;} }
            '+' => { if index > 0 { break; } }
            '0' => { if found_digit {nums.push(0); } }
            '1' => { found_digit = true; nums.push(1); }
            '2' => { found_digit = true; nums.push(2); }
            '3' => { found_digit = true; nums.push(3); }
            '4' => { found_digit = true; nums.push(4); }
            '5' => { found_digit = true; nums.push(5); }
            '6' => { found_digit = true; nums.push(6); }
            '7' => { found_digit = true; nums.push(7); }
            '8' => { found_digit = true; nums.push(8); }
            '9' => { found_digit = true; nums.push(9); }
            _ => { break; }
        }
        index += 1;
    }
    let numlen = nums.len() as i32;
    if numlen > 10 {
        // shortcut, number cannot fit in int32 space
        if neg {
            return std::i32::MIN;    
        } else {
            return std::i32::MAX;
        }
    }
    let mut result:i64 = 0;
    index = 0;
    for num in nums {
        index += 1;
        let pow: u32 = u32::try_from(numlen - index).unwrap();
        let mul = i64::pow(10, pow);
        let n = i64::from(num) * mul;
        result += i64::from(n);
    }
    if result > std::i32::MAX.into() {
        if neg {  return std::i32::MIN }
        return std::i32::MAX
    }
    let mut finalresult:i32 = i32::try_from(result).unwrap();

    if neg {
        finalresult *= -1;
    }
    finalresult
}
