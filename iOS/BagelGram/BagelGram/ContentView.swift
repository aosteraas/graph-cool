//
//  ContentView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 19/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import Apollo
import Network

struct ContentView: View {
    let controller = ImagesContoller()
    var body: some View {
        Text("Hello, World!")
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}

