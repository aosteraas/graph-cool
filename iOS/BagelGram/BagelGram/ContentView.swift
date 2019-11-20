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
    let n = Network()
    func doStuff() {
        apollo.fetch(query: GetImagesQuery()) { result in
            switch result {
            case.success(let result):
                if let source = result.data?.getImages?.first. {
                    print(source)
                }
            }
            
        }
    }
    
    
//    func GetShit() {
//
//        .fetch(query: GetImagesQuery()) {
//            result in
//          guard let data = try? result.get().data else { return }
//          print(data.hero?.name) // Luke Skywalker
//        }
//    }
    
    var body: some View {
        Text("Hello, World!")
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
