echo "Binding stated"
 sharpie bind \
 	-o Binding \
 	-sdk iphoneos10.2 \
    -scope . \
    	./RATreeView.h \
    -c \
        -Ibuild/Release-iphoneos/include -unified