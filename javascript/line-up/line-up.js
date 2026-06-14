//
// This is only a SKELETON file for the 'Line Up' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const format = (name, pos) => {
  let lastDigit = pos % 10;;
  let lastTwoDigits = pos % 100;
  let suffix = "";

  if (lastDigit == 1 && !(lastTwoDigits == 11))
    suffix = "st";
  else if (lastDigit == 2 && !(lastTwoDigits == 12))
    suffix = "nd";
  else if (lastDigit == 3 && !(lastTwoDigits == 13))
    suffix = "rd";
  else
    suffix = "th";

  return `${name}, you are the ${pos}${suffix} customer we serve today. Thank you!`
};
