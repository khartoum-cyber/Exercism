// @ts-check

// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Build a sign that includes both of the parameters.
 *
 * @param {string} occasion
 * @param {string} name
 *
 * @returns {string} template string combining both parameters
 */

export const buildSign = (occasion, name) => `Happy ${occasion} ${name}!`

/**
 * Build a birthday sign that conditionally formats the return string.
 *
 * @param {number} age
 *
 * @returns {string} template string based on age
 */

export function buildBirthdaySign(age) {
  switch (true) {
    case age >= 50:
      return 'Happy Birthday! What a mature fellow you are.'
    default:
      return 'Happy Birthday! What a young fellow you are.'
  }
}

/**
 * Build a graduation sign that includes multiple lines.
 *
 * @param {string} name
 * @param {number} year
 *
 * @returns {string} multi-line template string
 */

export const graduationFor = (name, year) => `Congratulations ${name}!\nClass of ${year}`;

/**
 * Determine cost based on each character of sign parameter that builds
 * the template string that includes the currency parameter.
 *
 * @param {string} sign
 * @param {string} currency
 *
 * @returns {string} cost to create the sign
 */

export function costOf(sign, currency) {
  const basePrice = 20;
  const letterCost = 2;
  var signCost = basePrice + (sign.length * letterCost);
  return `Your sign costs ${signCost.toFixed(2)} ${currency}.`
}
