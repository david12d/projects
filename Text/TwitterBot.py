import tweepy
from textblob import TextBlob

consumer_key = '53Hd0lQvM6odi6qjurmeuxJgz'
consumer_secret = 'wAK5JTFnGrcmhb3eEl4Gsff9qn1OgxYeLFzXG5QngB3xUDkJH3'

access_token = '959623164304109568-bci1guSqgyP7WEWDJQyEgqpDYcruyJ2'
access_token_secret = 'Q7QmRSS41DybOzRf5NRpI5YSZzsiTXblLwdVgEeZwGUbh'

auth = tweepy.OAuthHandler(consumer_key,consumer_secret)
auth.set_access_token(access_token,access_token_secret)

api = tweepy.API(auth)

public_tweets = api.search(input("Enter a one word topic: \n"), 
	rpp = 100 )

sum_sentiment = 0
for tweet in public_tweets:
	print(tweet.text)
	analysis = TextBlob(tweet.text)
	print(analysis.sentiment)
	
	#sum_sentiment = sum_sentiment + analysis.sentiment[0] 
#avg_sentiment = sum_sentiment/public_tweets.length()