// @ts-check

/**
 * Determine how many cards of a certain type there are in the deck
 *
 * @param {number[]} stack
 * @param {number} card
 *
 * @returns {number} number of cards of a single type there are in the deck
 */
export function cardTypeCheck(stack, card) {
  // 🚨 Use .forEach
  let counter = 0;
  stack.forEach(function(element) {
    if(element === card){
      counter++;
    }
  })
  return counter;
};

/**
 * Determine how many cards are odd or even
 *
 * @param {number[]} stack
 * @param {boolean} type the type of value to check for - odd or even
 * @returns {number} number of cards that are either odd or even (depending on `type`)
 */
export function determineOddEvenCards(stack, type) {
  // 🚨 Use a `for...of` loop
  let oddCardsCounter = 0;
  let evenCardsCounter = 0;

  for(let num of stack){
    if(num % 2 === 0)
      evenCardsCounter++;
    else
      oddCardsCounter++;
  }

  return type ? evenCardsCounter : oddCardsCounter;

  // switch (type) {
  //   case true:
  //     return evenCardsCounter;
  //   default:
  //     return oddCardsCounter;
  // }
}
