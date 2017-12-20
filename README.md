# Encryption-Client
Personal attempt at making a PGP-Style encryption client

Basically I was bored and wanted to code something to improve my skills and see how advanced of a programmer I really am.

I am basing this encryption program off of PGP (Pretty Good Encryption).

It works by generating a random number based off of the information for an account and tick count.

Then it scrambles a string based on that number which generates your public and private keys.

To encrypt a message you require a public key but not a private key.

To decrypt you require both the public and private key.

This way you can encrypt messages for someone using their public key but only they can decrypt as no one else will have their private key.
