# Generates localization files using twine.
# https://github.com/mobiata/twine
#
# gem install twine
#
# run using:
# ruby twine.rb

puts `twine generate-string-file twine.txt ./Android/Resources/values/Strings.xml --format android --lang en`
puts `twine generate-string-file twine.txt ./iOS/Resources/en.lproj/Localizable.strings --format apple --lang en`
puts `twine generate-string-file twine.txt ./ruby_lib/Twine.cs --format csharp --lang en`