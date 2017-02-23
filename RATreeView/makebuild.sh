echo "Hello"

rm -rf /output
mkdir output

echo "Building x86 libs"
xcodebuild -project RATreeView.xcodeproj -target RATreeView -sdk iphonesimulator -configuration Release clean build
cp build/Release-iphonesimulator/libRATreeView.a output/RATreeView-i386.a

echo "Building arm64 libs"
xcodebuild -project RATreeView.xcodeproj -target RATreeView -sdk iphoneos -arch arm64 -configuration Release clean build
cp build/Release-iphoneos/libRATreeView.a output/RATreeView-arm64.a

echo "Building armv7 libs"
xcodebuild -project RATreeView.xcodeproj -target RATreeView -sdk iphoneos -arch armv7 -configuration Release clean build
cp build/Release-iphoneos/libRATreeView.a output/RATreeView-armv7.a

echo "Building armv7s libs"
xcodebuild -project RATreeView.xcodeproj -target RATreeView -sdk iphoneos -arch armv7s -configuration Release clean build
cp build/Release-iphoneos/libRATreeView.a output/RATreeView-armv7s.a

echo "Building universal libs"
lipo -create -output output/RATreeView-universal.a output/RATreeView-i386.a output/RATreeView-arm64.a output/RATreeView-armv7.a output/RATreeView-armv7s.a