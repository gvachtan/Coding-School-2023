function incrementString(str) {
    let num = str.match(/\d+$/);
    if (!num) {
      return str + "1";
    } else {
      let number = parseInt(num[0]) + 1;
      return str.replace(/\d+$/, number);
    }
  }
  