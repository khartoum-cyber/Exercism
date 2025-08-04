// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  let sum = Number(array1.join('')) + Number(array2.join(''));
  return sum;
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  const str = value.toString();
  //const reversedStr = str.split('').reverse().join('');
  let reversedStr = "";
for (let i = 0; i < str.length; i++) {
  reversedStr = str[i] + reversedStr;
}
  return str === reversedStr;
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  if(input === '' || input === null || input === undefined){
    return 'Required field';
  }
  const number = Number(input);
  if(isNaN(number) || number === 0)
    return 'Must be a number besides 0'
  return '';
}