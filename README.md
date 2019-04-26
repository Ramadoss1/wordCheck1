# wordCheck1
word Validation
PRoblem statement:  

You are asked to validate words in a language that uses broad and slender vowels.

Broad Vowels are A, O, and U.

Slender Vowels are E and I.

A valid word in this language can never have a broad vowel on one side of a consonant group, and a slender on the other.

A Consonant Group is any number of consonants in a row.

 

Write code to determine if a word is in the language or not. Show your OOD, TDD, and SOLID skills.

 

Clarification: A single consonant is a consonant group as “any number” includes one.

 

 

Word

Valid/Invalid and Questions

Group

Valid  Word  (Broad vowels only)

Correct

Knife

Valid word because there is no consonant group

Incorrect, “Kn” and “f” are consonant groups. However, the word is valid because “I” and “e” are both slender.

Together

Good Word because “TH” is the consonant group and E (slender) on both side

Incorrect “o”, “g”, “e” broad, consonant group, slender. Invalid word.

Number

one sider is U (Broad) and another side is “E” so it is not a good word

 Correct

Pronounce

Not a valid because the un constant group has Broad vowel “U” on one side and Slender “E” on other side.

Is a single consonant should be considered a consonant group. ?

On the above Example PR can be ignored because it is on the beginning on the word

“n” is a single consonant can that be considered as Consonant Group

 

“pr”, “o”, “n”, “ou”, “nc”, “e”

 

You may simplify this exercise by expecting the 26 capital letters , You do not have to check for any characters other than those.

Sometimes it is useful to reduce a problem first. So for the sake of explanation I will reduce the possible input. The solution should accept 26 possible characters, but in this explanation we will use only 3. “I”, “X”, “O”.

 

Valid:

I, O, X, IX, IO, OX, OI, XI, XO, III, IOI, IXI, OOO, OIO, OXO, IXXI, OXXO, IOOIOIOIOOOIIIOO, OXXOIOIXXXI, OXOXXO, XIOIOXOXXOIX

 

Invalid:

IXO, OXI, OOIXXXXXO, IOXI, IXXXXXIOXXXXXXI



BUT your final code should handle the upper and lower case and all consonant instead of just three. 
