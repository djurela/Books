#!/usr/bin/env python2
# pw.py - An insecure password locker program.

PASSWORDS = {'email': 'xxx1234', 'blog': 'yyy1234', 'luggage': '1234'}

import sys, pyperclip

if len(sys.argv) < 2:
	print('Usage: python pw.py [account] - copy account password')
	sys.exit()

print('Arguments:')
max_len = 0
for i in range(0, len(sys.argv)): 
	if len(sys.argv[i]) > max_len:
		max_len =  len(sys.argv[i])
for i in range(0, len(sys.argv)): 
    print(str(i).ljust(5, '.') + sys.argv[i].rjust(max_len + 2))
	
account = sys.argv[1]
if account in PASSWORDS:
	pyperclip.copy(PASSWORDS[account])
	print('Password for ' + account + ' copied to clipboard.')
else:
	print('There is no account named ' + account)
    
