/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function(s, t) {
    if (s.length !== t.length) return false;
    
    var counts = new Map();

    // load the map
    for (const char of s) {
        let value = (counts.get(char) ?? 0) +1;
        counts.set(char, value);
    }

    // drain the map
    for (const char of t) {
        let values = (counts.get(char) ?? 0) -1;
        counts.set(char, values);
    }

    values = counts.values();  
    return [...values].every((v) => v === 0);
};

module.exports = isAnagram;