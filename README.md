<!-- check anagram-->

- Spec: program should be able to correctly create an Anagram object:

  - Input: new Anagram("Tar")
  - Output: Anagram() anagram.Word = "Tar"

- Spec: program should be able to compare one word to another word and determine if they are not anagrams:

  - Input: "cat" and "car"
  - Output: "false"

- Spec: program should be able to compare one word to another word and determine if they are anagrams:

  - Input: "tar" and "rat"
  - Output: "true"

- Spec: program should be able to compare one word to a list of words and determine if none are anagrams;

  - Input: "tar" vs "car", "elbow", "state"
  - Output: "no anagrams"

- Spec: program should be able to compare one word to a list of words and determine one match;

  - Input: "tar" vs "rat", "elbow", "state"
  - Output: "rat"

- Spec: program should be able to compare one word to a list of words and determine multiples matches;

  - Input: "tar" vs "rat", "art", "state"
  - Output: "rat" and "art"

- Spec: program should be able to limit the words it needs to check for efficiency;

  - Input: "tar" vs "rat", "car", "state"
  - Output: new list: "rat", "car" => return "rat"

- _Aspirational_ Spec: program should be able to compare one word to a list of user submitted words (entered as a string);

  - Input: "tar" vs "rat art string cider peach taste"
  - Output: "rat" and "art"
