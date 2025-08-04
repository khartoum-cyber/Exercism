/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */

export function cookingStatus(remainingTime){
    switch(remainingTime){
        case undefined:
            return 'You forgot to set the timer.';
        case '':
            return 'You forgot to set the timer.'
        case 0:
            return 'Lasagna is done.'
        default:
            return 'Not done, please wait.'
    }
}

export function preparationTime(layers, prepTime = 2){
    return layers.length * prepTime;
}

export function quantities(layers){
    let noodles = 0;
    let sauce = 0;

    layers.forEach(element => {
        if (element === "noodles") {
            noodles += 50;
        }
        if (element === "sauce") {
            sauce += 0.2;
        }
    });

    const object = {noodles, sauce};

    return object;
}

export function addSecretIngredient(friendsList, myList){
    myList.push(friendsList[friendsList.length - 1]);
}

export function scaleRecipe(recipe, portions){
    const scaled = {};
    for (let key in recipe) {
        scaled[key] = recipe[key] * (portions / 2);
    }
    return scaled;
}